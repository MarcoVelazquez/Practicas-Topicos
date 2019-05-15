using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_004
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
            X = Y = 90;
            PuntuacionLbl.Text = "Puntuación: " + puntuacion.ToString();

        }

        public enum Direction { Up, Down, Left, Right, Stop };
        public enum PrevDirection { PrevUp, PrevDown, PrevLeft, PrevRight };
        //public int[] K = new int[20];
        //public int[] J = new int[12];
        public int X, Y, FC=0, N, M, L=3;
        public int puntuacion = 0;
        List<int> snake_X = new List<int>();
        List<int> snake_Y = new List<int>();
        public int cabeza_X, cabeza_Y;
        
        //La variable L se supone es la longitud de la serpiente, en el metodo draw_Cuerpo 
        //Se deberían de dibujar todas las partes del cuerpo

        //K[] y J[] se supone son arreglos donde se van a guardar las coordenadas del cuerpo
        //Y en Draw_Cuerpo se deberán dibujar, el problema es hacer que las coordenadas se recorran

        //FC es Food Count, si hay una comida en pantalla no dibujará mas
        //En el metodo Comer esta la condición de que si esta encimado el pacman y la comida
        //Se aumente la longitud, se borre esa comida y se baje FC=0
        //Así se dibujará otra comida

        //N es la coordenada X para dibujar la comida y M la coordenada Y de la comida

        //enum PrevDirection quería que fuera algo para checar cual era la dirección previa 
        //Y evitar que si presionas alguna dirección 
        //y luego la contraria a la que estas llendo en ese momento se mueva para atras


            
        Direction dir = Direction.Right;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Get_coords(L, snake_X, snake_Y);
            //Al principio checa si estan encimados el gusano y la comida
            Comer(X, Y, N, M);

            
            //Si la dirección esta en stop es porque choco, y esto hace que se habilite el boton de reinicio
            if (dir != Direction.Stop)
            {
                switch (dir)
                {
                        //Dirección estará en Stop cuando se llegue a algún borde
                    case Direction.Down:
                        Y += 5;
                        if (Y > pictureBox1.Height) { dir = Direction.Stop; }
                        break;
                    case Direction.Up:
                        Y -= 5;
                        if (Y < 0) { dir = Direction.Stop; }
                        break;
                    case Direction.Left:
                        X -= 5;
                        if (X < 0) { dir = Direction.Stop; } 
                        break;
                    case Direction.Right:
                        X += 5;
                        if (X > pictureBox1.Width) { dir = Direction.Stop; }   
                        break;
                }

            }
            else
            {
                button1.Enabled = true;
            }

            pictureBox1.Invalidate();
            Clean_coords(L, snake_X, snake_Y);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Draw_cabeza(g, L);
            Draw_Cuerpo(g, L,snake_X,snake_Y);
            //Si la cuenta de comida es 0, se aumentará a 1 y se generará comida en un lugar random
            if (FC == 0)
            {
                FC=1;
                Random r = new Random();
                N = r.Next(0, 17);
                M = r.Next(0, 9);
            }
            //La comida se dibujará en los mismos valores hasta que la cuenta de comida vuelva a bajar a 0
            generateFood(g, N, M);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PuntuacionLbl_Click(object sender, EventArgs e)
        {
            
        }

        void Draw_cabeza(Graphics g, int L)
        {
            cabeza_X = X;
            cabeza_Y = Y;
            g.FillPie(Brushes.Black, cabeza_X, cabeza_Y, 20, 20, 30, 360);
            

        }

        void Get_coords(int L, List<int> snake_X, List<int> snake_Y)
        {
            for (int counter = 0; counter <= L; counter++)
            {
                if (dir == Direction.Right)
                {
                    snake_X.Add(cabeza_X-counter*15);
                    snake_Y.Add(cabeza_Y);

                }
                else if(dir == Direction.Left)
                {
                    snake_X.Add(cabeza_X + counter * 15);
                    snake_Y.Add(cabeza_Y);
                }
                else if (dir == Direction.Down)
                {
                    snake_X.Add(cabeza_X);
                    snake_Y.Add(cabeza_Y+counter*15);
                }
                else if (dir == Direction.Up)
                {
                    snake_X.Add(cabeza_X);
                    snake_Y.Add(cabeza_Y-counter*15);
                }

            }
        }

        void Clean_coords(int L, List<int> snake_X, List<int> snake_Y)
        {
            snake_X.Clear();
            snake_Y.Clear(); 
        }




        void Draw_Cuerpo(Graphics g, int L, List<int> snake_X, List<int> snake_Y)
        {
            //Dependiendo de la longitud debería dibujar circulos que midan lo mismo que el pacman
            /* for (int counter =0;counter<=L;counter++)
                 {
                     snake_X.Add(cabeza_X);
                     snake_Y.Add(cabeza_Y);
                 }*/
            


        

        for (int i =0; i <= L; i++)
            {
                
                
                    g.FillPie(Brushes.Black, snake_X[i], snake_Y[i], 20, 20, 30, 360);
                

            }

            
        }
        void Comer(int X, int Y, int N, int M)
        {
            //Se verifica si se enciman, la cuenta de comida se baja y se aumenta la longitud
            if (X == N * 30 && Y == M * 30)
            {
                if (dir != Direction.Stop)
                {


                    puntuacion += 1;
                    PuntuacionLbl.Text = "Puntuación: " + puntuacion.ToString();
                }
                else
                {

                    puntuacion = 0;
                    

                }
                
                FC = 0;
                L+=1;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dir != Direction.Stop)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        if (dir != Direction.Right)
                            dir = Direction.Left;
                        break;
                    case Keys.Right:
                        if (dir != Direction.Left)
                            dir = Direction.Right;
                        break;
                    case Keys.Up:
                        if (dir != Direction.Down)
                            dir = Direction.Up;
                        break;
                    case Keys.Down:
                        if (dir != Direction.Up)
                            dir = Direction.Down;
                        break;
                }
            }
        }

        void generateFood(Graphics g, int N, int M)
        {
            //Random r = new Random();
            g.FillEllipse(Brushes.Red, N * 30, M * 30, 20, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cuando se reinicia la dirección se hace a la derecha y se reinicia todo, longitud y posición
            button1.Enabled = false;
            dir = Direction.Right;
            X = Y = 90;
            FC = 0;
            L = 3;
            puntuacion = 0;
            PuntuacionLbl.Text = "Puntuación: " + puntuacion.ToString();
        }
        


    }
}
