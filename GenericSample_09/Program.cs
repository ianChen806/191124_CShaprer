using System;

namespace GenericSample_09
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass1 = new MyClass<int>();
            var myClass2 = new MyClass<string>();

            // Console.WriteLine(myClass1.GetType());
            // Console.WriteLine(myClass2.GetType());

            Console.ReadLine();
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