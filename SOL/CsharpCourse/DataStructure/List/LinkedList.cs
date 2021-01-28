using System;
using System.Collections.Generic;
using System.Text;

namespace SOL.CsharpCourse.DataStructure.List
{

    public class Node<T>

    {
        public Node(T value)
        {
            
        }
        public T Value { get; set; }

        public Node<T> Next { get; set; }
    }
    public  class SinglyLinkedList<T>
    {
        /// <summary>
        /// Contains the first element
        /// </summary>
        public Node<T> Head { get; private set; }

        /// <summary>
        /// Contains the last element
        /// </summary>
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        /// <summary>
        /// Says whether the list is empty.
        /// </summary>
        public bool IsEmpty => Count == 0;


        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {

            //save off the current head
            Node<T> tmp = Head;

            Head = node;


            //shifting the former head
            Head.Next = tmp;

            Count++;

            if (Count == 1)Tail = Head;
            
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            if (IsEmpty)
                Head = node;
            else
                Tail.Next = node;

            Tail = node;

            Count++;
        }



        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            Head = Head.Next;
            Count--;

            if (Count == 0)
                Tail = null;

        }

        public void RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                //find the penultimate node
                var current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }

            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }


    }
}
