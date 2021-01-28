using System;
using System.Collections.Generic;
using System.Text;

namespace SOL.CsharpCourse.DataStructure
{
   public static class ListDemocs
    {

        public static void Run()
        {
            List<int> list = new List<int>();

            Console.WriteLine("Check Capacity while Adding");
            for (int i = 0; i < 50; i++)
            {
                list.Add(i);
                Console.WriteLine("Count :"+list.Count +"  Capacity" + list.Capacity);
            }
            Console.WriteLine("Chack Capacity while Removing");
            for (int i = 40; i > 0; i--)
            {
                list.RemoveAt(i);
                Console.WriteLine("Count :" + list.Count + "  Capacity" + list.Capacity);
            }
            list.TrimExcess();
            Console.WriteLine("Chack Capacity After excess trimming");
            Console.WriteLine("Count :" + list.Count + "  Capacity" + list.Capacity);


            // Clear removes all the element leaving the capacity in place.
            list.Clear();
        }



        #region Linked List


        #endregion
    }
}
