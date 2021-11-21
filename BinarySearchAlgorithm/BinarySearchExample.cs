using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchAlgorithm
{
    //The complexity of Binary Search Algorithm is O(log N)
    public class BinarySearchExample
    {
        public static string BinarySeacrh(int[] arr, int first, int last, int value)
        {
            if (last < first)
                return "Not Found";
            var middle = (first + last) / 2;
            if (value > arr[middle])
                return BinarySeacrh(arr, middle + 1, last, value);

            else if (value < arr[middle])
                return BinarySeacrh(arr, first, middle - 1, value);

            else
                return middle.ToString();
        }
    }
}
