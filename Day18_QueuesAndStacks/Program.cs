using System;
using System.Collections.Generic;

namespace Day18_QueuesAndStacks
{
    /*
    1 . Two instance variables : one for your stack , and one for your queue .
    2. A void ch ) method that pushes a character onto a stack . pushCharacter ( char
    3. A void enqueueCharacter ( char ch ) method that enqueues a character in the
      queue instance variable .
    4. A char popCharacter ( ) method that pops and returns the character at the top of
      the stack instance variable .
    5. A char dequeueCharacter ( ) method that dequeues and returns the first character
     in the queue instance variable .
     */
    public class Program
    {
        //Write your code here
        Stack<char> s = new Stack<char>();
        Queue<char> q = new Queue<char>();
        void pushCharacter(char ch)
        {
            s.Push(ch);
        }

        void enqueueCharacter(char ch)
        {
            q.Enqueue(ch);
        }
        char popCharacter()
        {
            return s.Pop();
        }
        char dequeueCharacter()
        {
            return q.Dequeue();
        }
        static void Main(string[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Program obj = new Program();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
    

