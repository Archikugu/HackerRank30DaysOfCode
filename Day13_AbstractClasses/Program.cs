using System;

namespace Day13_AbstractClasses
{
    public class Program
    {
        abstract class Book
        {

            protected String title;
            protected String author;

            public Book(String t, String a)
            {
                title = t;
                author = a;
            }
            public abstract void display();
        }

        //Write MyBook class

        class MyBook : Book
        {
            private int price;

            public MyBook(string title, string author, int myPrice) : base(title, author)
            {
                price = myPrice;
            }

            public override void display()
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Price: " + price);
            }
        }



        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
