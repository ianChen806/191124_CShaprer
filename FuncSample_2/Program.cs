using System;

namespace FuncSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> action = Test;
            
            var result = action();
            
            Console.WriteLine(result);
        }

        private static int Test()
        {
            return 1;
        }
    }
}