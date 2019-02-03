using System;

namespace Delegados
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Actividad delegados \n");

            Transformer d = Doubler;
            Transformer i = IsPair;
            Transformer f = Factorial;



            Console.WriteLine("Números al doble ~ \n");

            int[] arrayD = { 1, 2, 3, 4, 5 };

            Util.TransformAll(arrayD, d);
            foreach (int a in arrayD)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\nEl número ingresado es par(0) | es impar(1) ~ \n");

            int[] arrayI = { 1, 2, 3, 4, 5 };

            Util.TransformAll(arrayI, i);
            foreach (int a in arrayI)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\nFactorial de los números ~ \n");

            int[] arrayF = { 1, 2, 3, 4, 5 };

            Util.TransformAll(arrayF, f);
            foreach (int a in arrayF)
            {
                Console.WriteLine(a);
            }



        }



        //Declaración del delegado

        public delegate int Transformer(int x);

        //Método que devuelve el doble del valor de entrada.

        static int Doubler(int x)
        {

            return x * 2;
        }

        //Método que devuelve 0 si el número ingresado es par, y 1 si no lo es.

        static int IsPair(int x)
        {
            int flag = 0;

            if (x % 2 == 0)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
            }

            return flag;
        }

        //Método que devuelve el factorial del número ingresado

        static int Factorial(int x)
        {
            int r = 0;

            if (x == 0)
            {

                r = 1;

            }
            else
            {

                r = x * Factorial(x - 1);

            }

            return r;
        }


        //Clase donde se tienen métodos utiles para el programa 
        class Util
        {

            //Método donde se invoca el delegado para todos los datos de un array

            public static void TransformAll(int[] vals, Transformer t)
            {
                for (int i = 0; i < vals.Length; i++)
                    vals[i] = t.Invoke(vals[i]);
            }
        }
    }
}
