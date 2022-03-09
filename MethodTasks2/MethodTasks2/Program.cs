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
            //Console.Write("Arraya ölçü verin: ");
            //int arrSize = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[arrSize];
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
                if(arr[minIndex] > arr[i])
                    minIndex = i;
                if(arr[maxIndex] < arr[i])
                    maxIndex = i;
            }
            arr[minIndex] = arr[maxIndex] + arr[minIndex];
            arr[maxIndex] = arr[minIndex] - arr[maxIndex];
            arr[minIndex] = arr[minIndex] - arr[maxIndex];
        }

        static void ConvertPositive(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
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
