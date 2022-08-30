using System;

namespace Day4_ClassVsInstance
{
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge > 0)
            {
                age = initialAge;
            }
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age = age + 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Task
             WriteaPerson class with an instance variable,age,andaconstructor that takes an
             integer,initial Age,asaparameter.The constructor must assign initial Age to
             age after confirming the argument passed as initial Age is not negative;ifa
             negative argument is passed as initial Age,the constructor should set age to0
             and print Age is not valid,setting age to0.. In addition,you must write
             the following instance methods:
             1. yearPasses()should increase the age instance variable by1.
             2. amlOld()should perform the following conditional actions:
                oIf age 13,print You are young ..
                •If age>13 and age<18,print You areateenager ..
                oOtherwise,print You are old ..
             To help you learn by example and complete this challenge,much of the code is
             provided for you,but you'll be writing everything in the future.The code that creates
             each instance of your Person class is in the main method.Don't worry if you don't
             understand it all quite yet!
             Note:Do not remove or alter the stub code in the editor.
             */

            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }

        }
    }
}
