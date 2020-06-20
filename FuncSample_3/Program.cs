using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            Predicate<int> predicate = i =>
            {
                return i > 3;
            };
            var result = values.Where(predicate);
            Console.WriteLine(string.Join(",", result));
        }
    }

    internal static class MyClass
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> input, Predicate<T> predicate)
        {
            if (input == null || predicate == null)
            {
                throw new Exception();
            }

            foreach (var item in input)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}