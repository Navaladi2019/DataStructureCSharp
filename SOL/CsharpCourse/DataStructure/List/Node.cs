using System;
using System.Collections.Generic;
using System.Text;

namespace SOL.CsharpCourse.DataStructure
{
    public class Node<T>

    {
        public Node(T value)
        {

        }
        public T value { get; set; }

        public Node<T> Next { get; set; }
    }

    public class NodeDemo
    {
        public static void Run()
        {
            Node<int> first = new Node<int>(5);
            Node<int> second = new Node<int>(10);
            first.Next = second;
            Node<int> third = new Node<int>(15);
            second.Next = third;
            PrintLinkedList(first);
        }

        public static void PrintLinkedList(Node<int> Node)
        {
            while(Node != null)
            {
                Console.WriteLine(Node.value);
                Node = Node.Next;
            }

        }
    }
}
