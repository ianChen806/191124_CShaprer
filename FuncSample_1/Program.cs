﻿using System;

namespace FuncSample_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> func = () =>
            {
                return 1;
            };

            var result = func.Invoke();
            Console.WriteLine(result);

            Func<int, string> func2 = value =>
            {
                return value.ToString();
            };
            var result2 = func2(123);
            Console.WriteLine(result2);
        }
    }
}