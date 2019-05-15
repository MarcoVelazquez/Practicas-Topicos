using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Numericos
{
    public class Metodos_Eliminacion
    {
        private static float[,,] c;
        private static float[,,] Matriz_temp
         = new float[3, 3, 3];
        //int iteracion = 1;

        public static float[,,] Eliminacion_Gauss_Simple(float[,,] a, float c1, float c2, float c3,int iteracion)
        {
           // c = new float[3, 3, 3];
            c = a;
            Matriz_temp = new float[3, 3, 3];


            float multiplo,x1,x2,x3,c1T,c2T,c3T;
            //int iteracion = 1;
            float[,,] r = new float[3,3,3];

            /*for (int i = 1; i < 2; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    for (int k = 1; k < 4; k++)
                    {
                        if (iteracion == 1)
                        {
                            multiplo = c[i, j, k+1] / c[i, j, k];

                            c[i,j,k] = 
                        }
                            
                        
                        
                    }

                }
            }*/
            switch (iteracion)
            {
                case 1:
                    multiplo = c[0, 0, 1] / c[0, 0, 0];

                   // Console.WriteLine("1 ---> "+multiplo);

                    Matriz_temp[0, 0, 0] = multiplo * c[0, 0, 0];
                    Matriz_temp[0 ,1 ,0] = multiplo * c[0, 1, 0];
                    Matriz_temp[0, 2, 0] = multiplo * c[0, 2, 0];

                    c1T = multiplo * c1;

                    c[0, 0, 1] = Matriz_temp[0, 0, 0] - c[0, 0, 1];
                    c[0, 1, 1] = Matriz_temp[0, 1, 0] - c[0, 1, 1];
                    c[0, 2, 1] = Matriz_temp[0, 2, 0] - c[0, 2, 1];

                    c2 = c1T - c2;

                    iteracion += 1;

                    Eliminacion_Gauss_Simple(c, c1, c2, c3,iteracion);

                    break;

                case 2:
                    multiplo = c[0, 0, 2] / c[0, 0, 0];

                    //Console.WriteLine("2 ---> " + multiplo);

                    Matriz_temp[0, 0, 0] = multiplo * c[0, 0, 0];
                    Matriz_temp[0, 1, 0] = multiplo * c[0, 1, 0];
                    Matriz_temp[0, 2, 0] = multiplo * c[0, 2, 0];

                    c1T = multiplo * c1;

                    c[0, 0, 2] = Matriz_temp[0, 0, 0] - c[0, 0, 2];
                    c[0, 1, 2] = Matriz_temp[0, 1, 0] - c[0, 1, 2];
                    c[0, 2, 2] = Matriz_temp[0, 2, 0] - c[0, 2, 2];

                    c3 = c1T - c3;

                    iteracion += 1;

                    Eliminacion_Gauss_Simple(c, c1, c2, c3, iteracion);

                    break;

                case 3:
                    multiplo = c[0, 1, 2] / c[0, 1, 1];

                    //Console.WriteLine("3 ---> " + multiplo);

                    Matriz_temp[0, 1, 1] = multiplo * c[0, 1, 1];
                    Matriz_temp[0, 2, 1] = multiplo * c[0, 2, 1];

                    c2T = multiplo * c2;

                    c[0, 1, 2] = Matriz_temp[0, 1, 1] - c[0, 1, 2];
                    c[0, 2, 2] = Matriz_temp[0, 2, 1] - c[0, 2, 2];

                    c3 = c2T - c3;

                    iteracion += 1;

                    Eliminacion_Gauss_Simple(c, c1, c2, c3, iteracion);


                    break;

                case 4:


                    x3 = c3/c[0, 2, 2];
                    x2 = (c2 -(x3 * c[0, 2, 1]))/c[0,1,1];
                    x1 = (c1 - (c[0, 0, 1] * x2) + (c[0, 0, 2] * x3)) / c[0, 0, 0];

                    r[0,0,0] = x1;
                    r[0,0,1] = x2;
                    r[0,0,2] = x3;

                    Console.WriteLine("X1: "+x1 +" X2: " + x2 + " X3: " + x3);

                    
                    break;
            }

            

            return r;
        }
    }
}
