using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOL
{
   public class Arrays
    {
        //lookUp o(1)
        //Push o(1)
        //insert o(n)
        //delete o(n)




        // Below are the datastructures in c# to get push ,pop,insert and delete with ease will mention all the available things about that data structure below

        //List<String>





        //Stack<String>



        //The Queue is a special case collection which represents a first in first out concept
        //Queue<String>
        //Queue qt = new Queue()
        //Queue.dequeue() removes first element
        //qt.Enqueue(); will add element at the last
        // For each loop will start in in the order the insertion occured
        public void Queue()
        {
            Queue<string> qt = new Queue<string>();
            qt.Enqueue("1"); 
            qt.Enqueue("2"); // will add element at last
            qt.Dequeue(); // will remove first added element
        }

        //4*4 = 16 bytes
        string[] arra = new string[10];


        /// <summary>
        /// Push Method does not exist in c# since arrays are fixed length initializer. You have to always add values to array always through index
        /// </summary>
        public void push()
        {
            // below in the demo code for javascript
            //arra.push("e");

            //below code is the close thing to push in c# with list
            List<string> ilstarray = arra.ToList();
            ilstarray.Append("e");

        }


        public void Pop()
        {
            //  for pop we can use stack
            // below in the demo code for javascript
            //arra.push("e");
            //below code is the close thing to pop in c# with list
            List<string> ilstarray = arra.ToList();
          //  ilstarray.

        }


    }
}
