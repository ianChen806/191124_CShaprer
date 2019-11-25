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
            myClass.Test(1);

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

        T Test< T, T2>(out T value1,in T2 value2)
            where T : new()
        {
            return new T();
        }
    }
}