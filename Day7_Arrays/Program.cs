using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Task
             Given an array,A,ofNintegers,print A's elements in reverse order asasingle line
             of space-separated numbers.
             */

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            ReversePrint(arr);
        }
        private static void ReversePrint(List<int> arr)
        {
            int length = arr.Count;
            for (int i = length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    Console.Write(arr[i] + " ");
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }
        }
    }
}
