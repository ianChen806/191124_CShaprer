using System;
using System.Collections.Generic;

namespace FuncSample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            Func<int, bool> action = (value) =>
            {
                return value > 3;
            };
            var result = new MyClass().Where(list, action);
            
            Console.WriteLine(string.Join(",", result));
        }
    }

    internal class MyClass
    {
        public List<int> Where(List<int> list, Func<int, bool> action)
        {
            var result = new List<int>();
            foreach (var item in list)
            {
                if (action(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}