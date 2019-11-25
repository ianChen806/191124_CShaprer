using System;

namespace FuncSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> action = Test;
            
            var result = action();
            var myCalss = new MyCalss();
            myCalss.TestMethod(action);
            
            Console.WriteLine(result);
        }

        private static int Test()
        {
            return 1;
        }
    }

    internal class MyCalss
    {
        public int TestMethod(Func<int> action)
        {
            var invoke = action.Invoke();
            return invoke;
        }
    }
}