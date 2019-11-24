using System;

namespace GenericSample_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            var result1 = Verify(new IdVerifier(), myClass);
            var result2 = Verify(new NameVerifier(), myClass);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        private static bool Verify<T>(T verifier, MyClass value)
            where T : VerifierBase
        {
            return verifier.Verify(value);
        }
    }

    internal class IdVerifier : VerifierBase
    {
        public override bool Verify(MyClass instance)
        {
            return true;
        }
    }

    internal class NameVerifier : VerifierBase
    {
        public override bool Verify(MyClass instance)
        {
            return false;
        }
    }

    internal abstract class VerifierBase
    {
        public abstract bool Verify(MyClass instance);
    }

    internal class MyClass
    {
    }
}