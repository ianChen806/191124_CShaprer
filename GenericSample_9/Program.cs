using System;

namespace GenericSample_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass1 = new MyClass<int>();
            var myClass2 = new MyClass<string>();
        }
    }

    internal class MyClass<T>
    {
        static MyClass()
        {
            Console.WriteLine(typeof(T).Name);
        }
    }
}