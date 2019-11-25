using System.Collections.Generic;

namespace GenericSample_07
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
        public List<TType> GetEmpty<TType>()
        {
            return new List<TType>();
        }
    }
}