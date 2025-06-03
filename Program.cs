using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        public static void Main(string[] args) 
        { 
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollction(a);

            SortedSet<int> c = new SortedSet<int>(a); //union
            c.UnionWith(b);
            PrintCollction(c);

            SortedSet<int> d = new SortedSet<int>(a); //intersection
            d.IntersectWith(b);
            PrintCollction(d);

            SortedSet<int> e = new SortedSet<int>(a); //difference
            e.ExceptWith(b);
            PrintCollction(e);
        }

        static void PrintCollction<T>(IEnumerable<T> collection)
        {
            foreach ( T obj in collection)
            {
                Console.Write(obj + "");
            }
            Console.WriteLine();
        }
    }
}