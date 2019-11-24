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
            var sw = new Stopwatch();
            var enumerable = Enumerable.Range(1, 1_000_000).ToList();

            sw.Restart();
            var result = 0;
            var list = new List<int>(enumerable);
            foreach (var item in list)
            {
                result += item;
            }
            sw.Stop();
            Console.WriteLine("List: " + sw.Elapsed.TotalMilliseconds + " ms");

            sw.Restart();
            result = 0;
            var arrayList = new ArrayList(enumerable);
            foreach (var item in arrayList)
            {
                result += (int)item;
            }
            sw.Stop();
            Console.WriteLine("ArrayList: " + sw.Elapsed.TotalMilliseconds + " ms");
        }
    }
}