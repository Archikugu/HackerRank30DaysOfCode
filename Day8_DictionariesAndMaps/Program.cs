using System;
using System.Collections.Generic;

namespace Day8_DictionariesAndMaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task
            Givennnames and phone numbers,assembleaphone book that maps friends'
            names to their respective phone numbers.You will then be given an unknown
            number of names to query your phone book for.For each name queried,print the
            associated entry from your phone book onanew line in the form
            name=phoneNumber;if an entry for name is not found,print Not found instead.
            Note:Your phone book should beaDictionary/Map/HashMap data structure.
            */

            int n = int.Parse(Console.ReadLine());
            var phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++ )
            {
                string[] s = Console.ReadLine().Split(' ');
                string name = s[0];
                string number = s[1];

                phoneBook.Add(name, number);
            }
            string searchName = "";
            while ((searchName = Console.ReadLine()) != null)
            {
                if (phoneBook.ContainsKey(searchName))
                {
                    Console.WriteLine(searchName + "=" + phoneBook[searchName]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }

    }
}
