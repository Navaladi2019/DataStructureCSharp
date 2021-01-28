using NUnit.Framework;
using SOL.CsharpCourse.Alogorithm;
using SOL.CsharpCourse.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure.Tests.Algorithm.Tests
{
    [TestFixture]
  public  class SortingTest
    {

        #region Sort
     
        public static int[][]Samples()
        {
            int[][] array = new int[9][];
            array[0]= new int[]{ 10, 18, 2, 5, 58, 9, 36, 100, 500, 66, 25, 999, 23 };
            array[1] = new int[] { -8,0,5};
            array[2] = new int[] { 0,0,1,0,8,2 };
            array[3] = new int[] { 15,2652,5656,44,2};
            array[4] = new int[] { 5,2,6,4+65,12,12 };
            array[5] = new int[] { -5,-44,-9999,465,88,66,2 };
            array[6] = new int[] { 10, 18, 2, 5, 58, 9, 36, 100, 500, 66, 25, 999, 23 };
            array[7] = new int[] { 10, 18, 2, 5, 58, 9, 36, 100, 500, 66, 25, 999, 23 };
            array[8] = new int[] { 10, 18, 2, 5, 58, 9, 36, 100, 500, 66, 25, 999, 23 };
            return array;
        }
        [Test]

        public static void BubbleSort()
        {
            TestSorting(Sorting.BubbleSortAscending);
        }

        [Test]

        public static void SelectionSort()
        {
            TestSorting(Sorting.SelectionSort);
        }

        [Test]

        public static void InsertionSort()
        {
            TestSorting(Sorting.InsertionSort);
        }

        [Test]
        public static void ShellSort()
        {
            TestSorting(Sorting.ShellSort);
        }
        public static void TestSorting(Action<int[]> sort)
        {
            for (int i = 0; i < Samples().Length; i++)
            {
                var collection = Samples()[i];
                sort(collection);
                CollectionAssert.IsOrdered(collection);
                printOutput(collection);
            }
        }

        private static void printOutput(int[] vs)
        {
            TestContext.WriteLine("---- Trace ----\n");
            foreach (var item in vs)
            {
                TestContext.Write(item + " , ");
            }

            TestContext.WriteLine("\n----------\n");
        }

        [Test]
        public void BubbleSortAscending()
        {
            int[] array = new int[] { 10, 18, 2, 5, 58, 9, 36, 100, 500, 66, 25, 999, 23 };
            Sorting.BubbleSortAscending(array);
            Assert.That(array, Is.Ordered.Ascending);
        }

        [Test]
        public void BubbleSortDescending()
        {
            int[] array = new int[] { 10, 18, 2, 5, 58, 9, 36, 100, 500, 66, 25, 999, 23 };
            Sorting.BubbleSortDescending(array);
            Assert.That(array, Is.Ordered.Descending);
        }


        #endregion //  Sort


        [Test]
        public static void TestRecursion()
        {
            Recurse(3);
        }


        public static int Recurse(int n)
        {
            if (n == 0)
                return 1;
            return n * Recurse(n - 1);
        }
    

      
    
    }
}
