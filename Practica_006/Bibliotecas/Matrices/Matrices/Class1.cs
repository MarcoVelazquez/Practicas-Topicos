using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    public class Suma
    {
         static float[,,,,] c;



        public static float[,,,,] DosxDos(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j<2; j++)
                {
                    c[i,j,0,0,0] = a[i,j,0,0,0] + b[i, j, 0, 0, 0];
                    
                }
            }

            return c;

            
        }

        public static float[,,,,] TresxTres(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        c[i, j, k, 0, 0] = a[i, j, k, 0, 0] + b[i, j, k, 0, 0];

                    }
                    

                }
            }

            return c;


        }

        public static float[,,,,] CuatroxCuatro(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for(int l = 0; l < 4; l++)
                        {
                            c[i, j, k, l, 0] = a[i, j, k, l, 0] + b[i, j, k, l, 0];
                        }
                        

                    }


                }
            }

            return c;


        }

        public static float[,,,,] CincoxCinco(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            for(int m = 0; m < 4; m++)
                            {
                                c[i, j, k, l, m] = a[i, j, k, l, m] + b[i, j, k, l, m];
                            }
                            
                        }


                    }


                }
            }

            return c;


        }

    }

    public class Resta
    {
        static float[,,,,] c;



        public static float[,,,,] DosxDos(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j, 0, 0, 0] = a[i, j, 0, 0, 0] - b[i, j, 0, 0, 0];

                }
            }

            return c;


        }

        public static float[,,,,] TresxTres(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        c[i, j, k, 0, 0] = a[i, j, k, 0, 0] - b[i, j, k, 0, 0];

                    }


                }
            }

            return c;


        }

        public static float[,,,,] CuatroxCuatro(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            c[i, j, k, l, 0] = a[i, j, k, l, 0] - b[i, j, k, l, 0];
                        }


                    }


                }
            }

            return c;


        }

        public static float[,,,,] CincoxCinco(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            for (int m = 0; m < 4; m++)
                            {
                                c[i, j, k, l, m] = a[i, j, k, l, m] - b[i, j, k, l, m];
                            }

                        }


                    }


                }
            }

            return c;


        }

    }

    public class Multiplicacion
    {
        static float[,,,,] c;



        public static float[,,,,] DosxDos(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j, 0, 0, 0] = a[i, j, 0, 0, 0] * b[i, j, 0, 0, 0];

                }
            }

            return c;


        }

        public static float[,,,,] TresxTres(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        c[i, j, k, 0, 0] = a[i, j, k, 0, 0] * b[i, j, k, 0, 0];

                    }


                }
            }

            return c;


        }

        public static float[,,,,] CuatroxCuatro(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            c[i, j, k, l, 0] = a[i, j, k, l, 0] * b[i, j, k, l, 0];
                        }


                    }


                }
            }

            return c;


        }

        public static float[,,,,] CincoxCinco(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            for (int m = 0; m < 4; m++)
                            {
                                c[i, j, k, l, m] = a[i, j, k, l, m] * b[i, j, k, l, m];
                            }

                        }


                    }


                }
            }

            return c;


        }

    }

    public class Diagonal
    {
        static float[,,,,] c;



        public static float[,,,,] DosxDos(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if(i == j)
                    {
                        c[i, j, 0, 0, 0] = a[i, j, 0, 0, 0] + b[i, j, 0, 0, 0];
                    }
                    else
                    {
                        c[i, j, 0, 0, 0] = 0;
                    }
                    

                }
            }

            return c;


        }

        public static float[,,,,] TresxTres(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if(i == j && j == k && k == i)
                        {
                            c[i, j, k, 0, 0] = a[i, j, k, 0, 0] + b[i, j, k, 0, 0];
                        }
                        else
                        {
                            c[i, j, k, 0, 0] = 0;
                        }
                        

                    }


                }
            }

            return c;


        }

        public static float[,,,,] CuatroxCuatro(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (i == j && j == k && k == l && l == i )
                            {
                                c[i, j, k, l, 0] = a[i, j, k, l, 0] + b[i, j, k, l, 0];
                            }
                            else
                            {
                                c[i, j, k, l, 0] = 0;
                            }
                        }


                    }


                }
            }

            return c;


        }

        public static float[,,,,] CincoxCinco(float[,,,,] a, float[,,,,] b)
        {
            c = new float[5, 5, 5, 5, 5];


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            for (int m = 0; m < 4; m++)
                            {
                                if (i == j && j == k && k == l && l == m && m == i)
                                {
                                    c[i, j, k, l, m] = a[i, j, k, l, m] + b[i, j, k, l, m];
                                }
                                else
                                {
                                    c[i, j, k, l, m] = 0;
                                }
                                
                            }

                        }


                    }


                }
            }

            return c;


        }

    }


}
