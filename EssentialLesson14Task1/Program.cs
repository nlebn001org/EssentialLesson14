using ExtMethod;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EssentialLesson14Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            arr.ToList().ForEach(i => Console.WriteLine(i));

            Console.WriteLine(new string('-', 10));

            GetEven(arr).ToList().ForEach(i => Console.WriteLine(i));

            IEnumerable<int> en = GetEven(arr);

            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Task number 4 with the extension method");
            int[] arrOfInt = en.GetArray();
            for (int i = 0; i < arrOfInt.Length; i++)
            {
                Console.WriteLine(i);
            }
        }

        static IEnumerable<int> GetEven(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0) yield return i;
            }

            //var a = from t in arr 
            //        where t % 2 == 0 
            //        select t;
            //return a;
        }
    }
}

namespace ExtMethod
{
    public static class ExtensionMethodClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            return list.ToArray();
        }
    }
}
