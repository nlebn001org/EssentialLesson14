using System;
using System.Collections.Generic;
using System.Linq;

namespace EssentialLesson14Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> a = new MyList<int>();

            a.Add(3);
            a.Add(2);
            a.Add(5);

            Console.WriteLine(a[2]);

            a.ToList().ForEach(t => Console.WriteLine(t));
        }
    }
}

