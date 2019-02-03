using System;

namespace Interfaces
{
    class MainClass
    {
        public interface ITransformer
        {
            int Transform(int x);
        }

        class Doubler : ITransformer
        {
            public int Transform(int x) { return x * x; }
        }
        class IsPair : ITransformer
        {
            public int Transform(int x)
            {
                if (x % 2 == 0) { return 0; }
                else return 1;
            }
        }
        class Factorial : ITransformer
        {
            public int Transform(int x)
            {
                for (int i = x - 1; i > 0; i--)
                {
                    x *= i;
                }
                return x;
            }
        }
        static void Main(string[] args)
        {
            Doubler S = new Doubler();
            Console.WriteLine(S.Transform(5));

            IsPair I = new IsPair();
            Console.WriteLine(I.Transform(5));
            Console.WriteLine(I.Transform(4));

            Factorial F = new Factorial();
            Console.WriteLine(F.Transform(5));

            Console.ReadKey(false);
        }
    }
}
