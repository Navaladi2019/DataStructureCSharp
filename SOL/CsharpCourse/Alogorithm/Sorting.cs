using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SOL.CsharpCourse.Alogorithm
{
   public static class Sorting
    {

        #region Bubble Sort
        /// <summary>
        /// Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order. for loop inside for loop with part boundary
        /// </summary>
        /// 
        public static void BubbleSort(int[] array)
        {
            BubbleSortAscending(array);
        }

        public static void BubbleSortAscending(int[] array)
        {
            //new int[] { 10, 18, 2, 5, 58, 9, 36, 100, 500, 66, 25, 999, 23 };
          


            for (int partIndex = 0; partIndex < array.Length; partIndex++)
            {
                

                for(int i= partIndex; i >0; i--)
                {
                    if (array[i-1] > array[i])
                    {
                        swap(array, i-1, i);
                    
                    }
                }
               
            }

         
        }

        public static  void BubbleSortDescending(int[] array)
        {
            bool hasswap = false;
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                hasswap = false;
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        swap(array, i, i + 1);
                        hasswap = true;
                    }
                }

                if (hasswap == false)
                {
                    break;
                }
            }


        }


        #endregion

        #region Selection Sort


        /// <summary>
        /// selection sort is shifting the largest element to part index.
        /// </summary>
        /// <param name="array"></param>
        public static void SelectionSort(int[] array)
        {
            for (int partIndex = array.Length-1; partIndex >0; partIndex--)
            {
                int largestAt = 0;
                for (int i = 1; i <= partIndex; i++)
                {
                    if(array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                swap(array,largestAt,partIndex);
            }
        }

        #endregion


        #region InsertionSort

        public static void InsertionSort(int[] array)
        {
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int currentUnsorten = array[partIndex];

                // 10 2 1 5 8 15 1 
                //i-1 is the algorithm
                //10 10 1 5 8 15 1 -> 2 10 1 5 8 15 1 for partindex 1 and i will be 0
                //1 2 10 5 8 15 1 for partindex 2 and i will be 0
                //1 2 5 10 8 15 1 for partindex 3 and i wil be 2
                //1 2 5 8 10 15 1 for partindex 4 and i will be 3
                //1 2 5 8 10 15 1 for partindex 5 and i will be 5
                //1 1 2 5 8 10 15 for partindex6 and i will be 1



                int i = 0;
                for ( i = partIndex; i > 0 && array[i-1] > currentUnsorten;  i--)
                {
                    array[i] = array[i - 1];
                }
                array[i] = currentUnsorten;
            }
        }



        #endregion


        #region ShellSort

        /// <summary>
        /// 1)Based on Insertion Sort
        /// 2)Insertion Sort is based on per-Sorted array
        /// 3)Basic idea: Pre-Sort the input and switch to insertion sort
        /// 4) Gap is used for pre-sorting => swap distant elements
        /// 5)When gap =1, insertion sort finishes work
        /// </summary>
        /// <param name="array"></param>
        public static void ShellSort(int[] array)
        {
            int gap = array.Length / 2;

            
                while (gap >= 1)
                {

                    for (int i = gap; i < array.Length; i++)
                    {
                        for (int j = i; j >= gap && array[j] < array[j-gap] ; j-= gap)
                        {
                            swap(array, j, j - gap);
                        }
                    }
                  
                    gap /= 2;
                
            }
        }




        #endregion


        #region MergeSort

        public static void MergeSort()
        {

        }
        #endregion
        public static void swap(int[]array,int i,int j)
        {
            if (i == j)
                return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
