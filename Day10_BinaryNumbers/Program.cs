using System;

namespace Day10_BinaryNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Task
            Givenabase-10 integer,n,convert it to binary(base-2).Then find and print the
            base-10 integer denoting the maximum number of consecutive 1's in n's binary
            representation.When working with different bases,it is common to show the base
            asasubscript.
             */

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            var reminder = 0;
            var count = 0;
            var max = 0;
            while (n > 0)
            {
                reminder = n % 2;
                n /= 2;
                if (reminder == 1)
                {
                    count++;
                    max = Math.Max(max, count);
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine(max);

        }
    }
}
