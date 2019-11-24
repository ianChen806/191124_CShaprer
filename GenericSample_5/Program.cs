using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GenericSample_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            var enumerable = Enumerable.Range(1, 1_000_000).ToList();
            var result = 0;

            var list = new List<int>(enumerable);
            var arrayList = new ArrayList(enumerable);

            sw.Restart();
            foreach (var item in list)
            {
                result += item;
            }
            sw.Stop();
            Console.WriteLine("List: " + sw.Elapsed.TotalMilliseconds + " ms");

            sw.Restart();
            foreach (var item in arrayList)
            {
                result += (int)item;
            }
            sw.Stop();
            Console.WriteLine("ArrayList: " + sw.Elapsed.TotalMilliseconds + " ms");
        }
    }
}