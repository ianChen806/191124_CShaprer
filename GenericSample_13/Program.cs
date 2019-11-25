using System;

namespace GenericSample_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass1 = new MyClass();
            var myClass2 = new MyClass2();

            Init(myClass1);
            Init(myClass2);

            Console.WriteLine(myClass1.Name);
            Console.WriteLine(myClass2.Id);

            Console.ReadLine();
        }

        private static void Init<T>(T myClass)
        {
            if(myClass is MyClass a)
            {
                a.Name = "Test";
            }
            if(myClass is MyClass2 b)
            {
                b.Id = 123;
            }
        }
    }

    internal class MyClass2
    {
        public int Id { get; set; }
    }

    internal class MyClass
    {
        public string Name { get; set; }
    }
}