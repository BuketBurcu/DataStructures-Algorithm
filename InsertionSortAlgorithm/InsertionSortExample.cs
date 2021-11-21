using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSortAlgorithm
{
    //The complexity of Binary Search Algorithm is O(N^2)
    public class InsertionSortExample
    {
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int deger = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > deger)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = deger;
            }
            return arr;
        }
    }
}