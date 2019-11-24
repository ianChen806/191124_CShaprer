namespace GenericSample_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass<int>(1);
        }
    }

    internal class MyClass<TClass>
    {
        private TClass _field;

        public TClass MyProperty { get; set; }

        public MyClass(TClass field)
        {
            _field = field;
        }

        void Test<TMethod>(TMethod value)
        {
        }
    }

    interface IInterface<TInterface>
    {
    }
}