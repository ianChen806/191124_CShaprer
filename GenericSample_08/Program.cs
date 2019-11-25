using System;

namespace GenericSample_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Add("Test");

            myClass.Add("Test", 123);
            myClass.Add<int>();
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

        public void Add<T>()
        {
            throw new NotImplementedException();
        }
    }
}