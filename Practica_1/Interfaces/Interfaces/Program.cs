using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Program
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
                if (x % 2 == 0) {return 0;}
                else return 1;
            }
        }
        class Factorial : ITransformer
        {
            public int Transform(int x)
            {
                for (int i = x-1; i > 0; i--)
                {
                    x *= i;
                }
                return x;
            }
        }

        public class Util
        {
            public static void TransformAll(int[] values, ITransformer t)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = t.Transform(values[i]);
                    Console.WriteLine(values[i]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
            Doubler S = new Doubler();
            IsPair I = new IsPair();
            Factorial F = new Factorial();
  
            int[] valuesS = { 1, 2, 3, 4, 5 };
            int[] valuesI = { 1, 2, 3, 4, 5 };
            int[] valuesF = { 1, 2, 3, 4, 5 };

            Util.TransformAll(valuesS, S);
            
            Util.TransformAll(valuesI, I);

            Util.TransformAll(valuesF, F);

            Console.ReadKey(false);
        }
    }
}
