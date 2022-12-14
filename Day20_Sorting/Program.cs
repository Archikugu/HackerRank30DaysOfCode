using System;
using System.Collections.Generic;
using System.Linq;

namespace Day20_Sorting
{
    /*
     Task
        Given an array, a, of size n distinct elements, sort the array in ascending order usinng
        the Bubble Sort algorithm above. Once sorted, print the following 3 lines:
        1. Array is sorted in numSwaps swaps.
        where numSwaps is the number of swaps that took place.
        2. First Element: firstElement
        where firstElement is the first element in the sorted array.
        3. Last Element: lastElement
        where  is the last element in the sorted array.
        Hint: To complete this challenge, you will need to add a variable that keeps a running tally of all swaps that occur during execution.
     */
    internal class Program
    {

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            // Write your code here
            BubbleSort(a);
        }
        public static void BubbleSort(List<int> list)
        {
            var numberOfSwaps = 0;
            for (var i = 0; i < list.Count; i++)
            {
                for (var j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        numberOfSwaps++;
                    }
                }
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            Console.WriteLine($"First Element: {list[0]}");
            Console.WriteLine($"Last Element: {list[list.Count - 1]}");


        }
    }

}



