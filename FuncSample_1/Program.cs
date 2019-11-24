using System;

namespace FuncSample_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> action = () =>
            {
                return 1;
            };

            var invoke = action.Invoke();
            Console.WriteLine(invoke);

            Func<int, string> action2 = value =>
            {
                return value.ToString();
            };
            Console.WriteLine(action2(123));
        }
    }
}