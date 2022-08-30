using System;

namespace Day3_IntroToConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Task
                Given an integer,n,perform the following conditional actions:
                •Ifnis odd,print Weird
                •Ifnis even and in the inclusive range of2to5,print Not Weird
                •Ifnis even and in the inclusive range of6to 20,print Weird
                •Ifnis even and greater than 20,print Not Weird
                Complete the stub code provided in your editor to print whether or notnis weird.
             */
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            if (N % 2 == 1 || (N >= 6 && N <= 20))
            {
                Console.Write("Weird");
            }
            else
            {
                Console.Write("Not Weird");
            };
        }
    }
}
