using System.Collections.Generic;

namespace GenericSample_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();

            var empty = myClass.GetEmpty<int>();
        }
    }

    class MyClass
    {
        public List<T> GetEmpty<T>()
        {
            return new List<T>();
        }
    }
}