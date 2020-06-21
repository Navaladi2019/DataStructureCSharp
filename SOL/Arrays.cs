using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            //Queue<String>
            //Stack<String>


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

         
            // below in the demo code for javascript
            //arra.push("e");

            //below code is the close thing to pop in c# with list
            List<string> ilstarray = arra.ToList();
          //  ilstarray.

        }


    }
}
