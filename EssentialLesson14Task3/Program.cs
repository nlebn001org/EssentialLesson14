using System;
using System.Collections.Generic;

namespace EssentialLesson14Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> dict1 = new MyDictionary<int, string>();
            dict1.Add(1, "test");
            dict1.Add(2, "test");
            dict1.Add(3, "test");

            foreach (KeyValuePair<int, string> item in dict1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine(new string('-',10));

            Console.WriteLine(dict1[0]);

            Console.WriteLine(new string('-', 10));

            Console.WriteLine(dict1.Count);

        }
    }
}
