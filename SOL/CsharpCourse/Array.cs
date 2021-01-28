using System;
using System.Collections.Generic;
using System.Text;

namespace SOL.CsharpCourse
{
  public static  class ArraysCourse
    {

        public static void ArrayTest()
        {
            // JaggedArray();
            IterateOver(new int[] { 1, 2, 3 });
        }

        // unsafe keyword is used to work with pointers and also to tell its not using managed code.
        private static unsafe void IterateOver(int[] array)
        {
            // fixed keyword is used to tell gc not to move object while working with pointer since pointer deals directly with memory address and not reference of that object.
            fixed (int* b = array)
            {
                int* p = b;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(*p);
                    p = 1 + p;
                }
            }

        }

        public static void MuliDimensionalArray()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 1, 2, 3 } };

        }


        public static void JaggedArray()
        {
            // with jagged array we can have second array in different length there by optomizing memory
            int[][] myarray = new int[4][];
            myarray[0] = new int[2];
            myarray[1] = new int[5];
            myarray[2] = new int[4];
            myarray[3] = new int[3];

            for (int i = 0; i < myarray.Length; i++)
            {
                for (int j = 0; j < myarray[i].Length; j++)
                {
                    Console.WriteLine(myarray[i][j]);
                }
            }
        }


    }
}
