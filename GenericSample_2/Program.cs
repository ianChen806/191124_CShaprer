namespace GenericSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = new Calculate();
            int add1 = calculate.Add(1, 2);

            decimal add2 = calculate.Add(1m, 2m);

            double add3 = calculate.Add(1d, 2d);
        }
    }

    internal class Calculate
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public decimal Add(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }
    }
}