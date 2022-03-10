using System;

namespace MethodTasks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //int[] arr = { 12, 24, 2, 11, 5 };
            //foreach (var el in arr)
            //{
            //    Console.Write($"{el} ");
            //}
            //Console.WriteLine();
            //Swap(arr);
            //foreach (var el in arr)
            //{
            //    Console.Write($"{el} ");
            //}
            #endregion

            #region Task 2
            //int[] arr = { -6, -3, -1, -9, -8, 5, 6, 3 };
            //ConvertPositive(ref arr);
            //foreach (var el in arr)
            //{
            //    Console.Write($"{el} ");
            //}
            #endregion
        }

        static void Swap(int[] arr)
        {
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[minIndex] > arr[i])
                    minIndex = i;
                if (arr[maxIndex] < arr[i])
                    maxIndex = i;
            }
            arr[minIndex] = arr[maxIndex] + arr[minIndex];
            arr[maxIndex] = arr[minIndex] - arr[maxIndex];
            arr[minIndex] = arr[minIndex] - arr[maxIndex];
        }
        static void ConvertPositive(ref int[] arr)
        {
            //arr = new int[8] { -6, -2, -1, -10, -7, 5, 6, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * -1;
                }
            }
        }
    }
}
