using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            Predicate<int> test = i =>
            {
                return i > 3;
            };
            var @where = ints.Where(test);
        }
    }

    internal static class MyClass
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> ints, 
            Predicate<T> predicate)
        {
            foreach(var item in ints)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}