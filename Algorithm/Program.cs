using BinarySearchAlgorithm;
using InsertionSortAlgorithm;
using MergeSortAlgorithm;
using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi elemanlarını giriniz.");
            var variables = Console.ReadLine().Split(" ");
            int[] array = new int[variables.Length];

            #region BinarySearch

            for (int i = 0; i < variables.Length; i++)
            {
                array[i] = (Int32.Parse(variables[i]));
            }
            var initial = array[0];
            var değid = array.Length;
            var end = array[array.Length - 1];
            Console.WriteLine("Aramak istediğiniz değeri giriniz:");
            var variable = Console.ReadLine();
            var findVariable = Int32.Parse(variable);

            var sonuc = BinarySearchExample.BinarySeacrh(array, initial, end, findVariable);
            Console.WriteLine("sonuc [0]", sonuc);

            #endregion

            #region InsertionSort

            //int[] arr = new int[]
            //{
            //   4,56,34,2,54,10,55
            //};
            //var sonucInsertion = InsertionSortExample.InsertionSort(arr);
            //Console.WriteLine("sonuc [0]", sonucInsertion);

            #endregion

            #region MergeSort

            //MergeSortExample.Divide(array, 0, array.Length);
            //Console.WriteLine("sonuc [0]", sonuc);

            #endregion
        }
    }
}
