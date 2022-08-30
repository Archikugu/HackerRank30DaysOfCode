﻿using System;
using System.IO;

namespace Day9_Recursion3
{
    internal class Program
    {
        class Result
        {

            /*
             * Complete the 'factorial' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts INTEGER n as parameter.
             */

            public static int factorial(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * factorial(n - 1);
                }
            }

        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
