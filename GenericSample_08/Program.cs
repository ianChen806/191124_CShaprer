using System;
using System.Collections.Generic;

namespace GenericSample_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Add<string>("Test");

            myClass.Add<string, int>("Test", 123);

            myClass.Add<string>("Test", "123");
        }
    }

    class MyClass
    {
        public void Add<TValue>(TValue value)
        {
            throw new NotImplementedException();
        }

        public void Add<TValue1, TValue2>(TValue1 value1, TValue2 value2)
        {
            throw new NotImplementedException();
        }

        public void Add<TValue1>(TValue1 value1, string value2)
        {
            throw new NotImplementedException();
        }
    }
}