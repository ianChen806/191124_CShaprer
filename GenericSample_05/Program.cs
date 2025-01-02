using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GenericSample_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List();
            ArrayList();
        }

        private static void ArrayList()
        {
            var sw = new Stopwatch();
            var enumerable = Enumerable.Range(1, 1_000_000).ToList();

            sw.Restart();
            var arrayList = new ArrayList();
            foreach (var item in enumerable)
            {
                arrayList.Add(item);
            }
            sw.Stop();
            Console.WriteLine("ArrayList: " + sw.Elapsed.TotalMilliseconds + " ms");

            object arraytItem = arrayList[0];
        }

        private static void List()
        {
            var sw = new Stopwatch();
            var enumerable = Enumerable.Range(1, 1_000_000).ToList();

            sw.Restart();
            var list = new List<int>();
            foreach (var item in enumerable)
            {
                list.Add(item);
            }
            sw.Stop();
            Console.WriteLine("List: " + sw.Elapsed.TotalMilliseconds + " ms");

            int listItem = list.First();
        }
    }
}
