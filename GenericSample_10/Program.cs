using System;

namespace GenericSample_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var genericFactory = new GenericFactory();
            MyClass instance = genericFactory.Instance<MyClass>();
            instance.Test();
        }
    }

    internal class MyClass
    {
        public void Test()
        {
            Console.WriteLine("Test");
        }
    }

    internal class GenericFactory
    {
        public TType Instance<TType>()
            where TType : new()
        {
            return new TType();
            // return Activator.CreateInstance<TType>();
        }
    }
}