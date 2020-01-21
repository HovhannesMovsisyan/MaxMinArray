using System;

namespace MaxMinSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 5, -6, 8, 41, 21, 99, 2 };
            int dif=GetDifferenceMaxMinOfArray(arr);
            Print(dif, "The difference max and min elements of Array is.... ");
        }
        #region Returns The difference max and min elements of Array and Prints
        /// <summary>
        /// Gets the difference between maximum and minimum elements of Array
        /// </summary>
        /// <param name="arr">integer Array</param>
        /// <returns>The difference max and min elements of Array</returns>
        static int GetDifferenceMaxMinOfArray(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                else if(arr[i]<min)
                    min = arr[i];
            }
            return max - min;
        }
        /// <summary>
        /// Writes the int value difference between maximum and minimum elements of Array
        /// </summary>
        /// <param name="dif"></param>
        /// <param name="text"></param>
        static void Print(int dif,string text)
        {
            Console.WriteLine($"{text}{dif}");
        }
        #endregion
    }
}
