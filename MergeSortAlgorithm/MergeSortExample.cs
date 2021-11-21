using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortAlgorithm
{
    //The complexity of Binary Search Algorithm is O(N log N)
    public class MergeSortExample
    {
        public static void Divide(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Divide(arr, left, middle);
                Divide(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }

        public static void Merge(int[] arr, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            for (int i = 0; i < leftArray.Length; i++)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < rightArray.Length; j++)
                rightArray[j] = arr[middle + 1 + j];
            int a = 0, b = 0;
            int k = left;
            while (a < leftArray.Length && b < rightArray.Length)
            {
                if (leftArray[a] <= rightArray[b])
                {
                    arr[k] = leftArray[a];
                    a++;
                }
                else
                {
                    arr[k] = rightArray[b];
                    b++;
                }
                k++;
            }
            while (a < leftArray.Length)
            {
                arr[k] = leftArray[a];
                a++;
                k++;
            }
            while (b < rightArray.Length)
            {
                arr[k] = rightArray[b];
                b++;
                k++;
            }
        }
    }
}