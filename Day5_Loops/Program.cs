using System;

namespace Day5_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task
            Given an integer,n,print its first 10 multiples.Each multiplenxi
            (where 1≤i≤10)should be printed onanew line in the form:nxi=result.
            */

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
