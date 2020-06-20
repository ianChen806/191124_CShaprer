using System;
using System.Linq;

namespace GenericSample_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            var value = myClass.GetIndex<MyEnum>(MyEnum.D);

            Console.WriteLine(value);
        }
    }

    enum MyEnum
    {
        A,
        B,
        D,
    }

    internal class MyClass
    {
        public int GetIndex<TEnum>(TEnum value)
            where TEnum : Enum
        {
            var list = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();
            return list.IndexOf(value);
        }
    }
}