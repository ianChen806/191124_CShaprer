using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GenericSample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<string>();
            list1.Add("123");

            var list2 = new List<int>();
            list2.Add(1);

            var list3 = new List<MyCalss>();
            list3.Add(new MyCalss());
        }
    }

    internal class MyCalss
    {
    }
}