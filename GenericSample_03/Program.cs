﻿using System.Collections;

namespace GenericSample_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("a");
            arrayList.Add(new MyCalss());

            var list = new ArrayList();
            list.Add("Test");
            list.Add("123");
        }
    }

    internal class MyCalss
    {
    }
}