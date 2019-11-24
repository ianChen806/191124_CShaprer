using System;

namespace ActionSample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = () =>
            {
                Console.WriteLine("123");
            };
            action.Invoke();

            Action<string> action2 = value =>
            {
                Console.WriteLine(value);
            };
            action2("test");
        }
    }
}