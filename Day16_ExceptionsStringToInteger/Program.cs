using System;
/*
 Task
 Read a string, S, and print its integer value; if S cannot be converted to an integer,
 print Bad String.
 */
namespace Day16_ExceptionsStringToInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            try
            {
                var i = int.Parse(S);
                Console.Write(i);
            }
            catch
            {
                Console.Write("Bad String");
            }
        }
    }

}
