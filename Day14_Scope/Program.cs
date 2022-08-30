using System;
using System.Linq;

namespace Day14_Scope
{
    public class Program
    {
        /*
             Task
             Complete the Difference class by writing the following:
             A class constructor that takes an array of integers as a parameter and saves it to
             the_elements instance variable.
             A computeDifference method that finds the maximum absolute difference
             between any 2 numbers in _elements and stores it in the
             mazimum Difference instance variable.
        */
        class Difference
        {
            private int[] elements;
            public int maximumDifference;
            // Add your code here
            public Difference(int[] arr)
            {
                elements = arr;
            }
            public void computeDifference()
            {
                var min = int.MaxValue;
                var max = int.MinValue;
                for (var i = 0; i < elements.Length; i++)
                {
                    min = Math.Min(min, elements[i]);
                    max = Math.Max(max, elements[i]);
                }
                maximumDifference = max - min;
            }


        } // End of Difference Class
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}

