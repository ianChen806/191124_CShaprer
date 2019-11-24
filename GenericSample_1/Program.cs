using System.Collections.Generic;

namespace GenericSample_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    internal class MyClass<T>
    {
        private readonly List<T> _list = new List<T>();

        void Add(T instance)
        {
            _list.Add(instance);
        }

        List<T> GetAll()
        {
            return _list;
        }
    }
}