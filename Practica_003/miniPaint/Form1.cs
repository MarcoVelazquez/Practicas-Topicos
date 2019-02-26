using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPaint
{
    public partial class GrosorLbl : Form
    {
        public GrosorLbl()
        {
            InitializeComponent();
            canvas = drawArea.CreateGraphics();
            selectedTool = 3;
            SoloLapizBtt.Enabled = false;
            puntos = new List<Point>();
            grosor = 5;

            selectedColor = Color.Black;
        }
        Graphics canvas;
        int selectedTool;
        List<Point> puntos;
        Color selectedColor;
        float grosor;

        bool isMousePressed = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            //drawArea.Invalidate();
        }

        private void drawArea_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //g.DrawLine((new Pen(Color.Black,30)), 0, 0, 300, 300);
        }

        private void drawArea_MouseClick(object sender, MouseEventArgs e)
        {
            int w = 50;
            int h = 50;
            switch (selectedTool)
            {        
                case 0:
                    {
                        //Circulo
                        canvas.FillEllipse(new SolidBrush(selectedColor), e.X-w/2, e.Y-h/2, w, h);
                        break;
                    }

                case 1:
                    //Cuadrado
                    canvas.DrawRectangle(new Pen(selectedColor, grosor), e.X - w / 2, e.Y - h / 2, w, h);
                    break;

                case 2:

                    //Pentagono
                    Point point1 = new Point(e.X+20, e.Y+30);
                    Point point2 = new Point(e.X+10, e.Y+60);
                    Point point3 = new Point(e.X-10, e.Y+60);
                    Point point4 = new Point(e.X-20, e.Y+30);
                    Point point5 = new Point(e.X, e.Y);
                  
                    Point[] pentaPoints =
                             {
                             point1,
                             point2,
                             point3,
                             point4,
                             point5,
                             };

                    canvas.DrawPolygon(new Pen(selectedColor,grosor), pentaPoints);

                    break;
                case 3:
                    //Sin figura
                    if (isMousePressed)
                    {
                        puntos.Add(new Point(e.X, e.Y));
                        if (puntos.Count > 1)
                            canvas.DrawLines(new Pen(selectedColor, grosor), puntos.ToArray());
                    }
                    break;
                case 4:
                    //Dodecagono
                    canvas.DrawImage(Image.FromFile(@"./../Dodecagono.PNG") ,e.X-100,e.Y-100);
                    
                    break;
                case 5:
                    //Rectangulo
                    canvas.DrawRectangle(new Pen(selectedColor, grosor), e.X - 60 / 2, e.Y - 70 / 2, 50, 70);
                    break;
                case 6:
                    //Triangulo
                    Point tpoint1 = new Point(e.X + 30, e.Y + 60);
                    Point tpoint2 = new Point(e.X -30, e.Y + 60);
                    Point tpoint3 = new Point(e.X , e.Y );

                    Point[] tPoints =
                            {
                            tpoint1,
                             tpoint2,
                             tpoint3,
                             
                             };

                    canvas.DrawPolygon(new Pen(selectedColor, grosor), tPoints);



                    break;

            }
            
           
        }

       

        private void clearButton_Click(object sender, EventArgs e)
        {
            canvas.Clear(Color.White);
            drawArea.Invalidate();

            puntos.Clear();
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            resetTools();
            ((Button)sender).Enabled = false;
            selectedTool = 0;

        }

        private void rectButton_Click(object sender, EventArgs e)
        {
            resetTools();
            ((Button)sender).Enabled = false;
            selectedTool = 5;
        }

        void resetTools()
        {
            foreach (Control b in toolBox.Controls)
                b.Enabled = true;
        }

        private void drawArea_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (selectedTool == 3)
            {
                if (isMousePressed)
                {
                    puntos.Add(new Point(e.X, e.Y));
                    if (puntos.Count > 1)
                        canvas.DrawLines(new Pen(selectedColor, grosor), puntos.ToArray());
                }
                //canvas.FillEllipse(Brushes.Black, e.X, e.Y, 10, 10);
            }
            
        }

        private void drawArea_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePressed = true;
        }

        private void drawArea_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
            puntos.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetTools();
            selectedTool = 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetTools();
            selectedTool = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Red;
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TriánguloBtt.Visible = true;
            else if (e.KeyCode == Keys.Escape)
                TriánguloBtt.Visible = false;

        }

        private void FuchsiaBtt_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Fuchsia;
        }

        private void BlackBtt_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Black;
        }

        private void BlueBtt_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Blue;
        }

        private void LimeBtt_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Lime;
        }

        private void AquaBtt_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Aqua;
        }

        private void YellowBtt_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Yellow;
        }

        private void MaroonBtt_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Maroon;
        }

        private void SoloLapizBtt_Click(object sender, EventArgs e)
        {
            resetTools();
            selectedTool = 3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ColorBtt_Click(object sender, EventArgs e)
        {
            ColorDialog colorBtt = new ColorDialog();
            if (colorBtt.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorBtt.Color; }
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (grosor > 0 && grosor < 30)
            {
                grosor = float.Parse(GrosorTxtBox.Text);
            }
            else
            {
                grosor = 5;
            }
        }*/

        private void GrosorCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            grosor = float.Parse(GrosorCmbx.Text);
        }

        private void GrosorCmbx_Click(object sender, EventArgs e)
        {
            
        }

        private void DodecagonoBtt_Click(object sender, EventArgs e)
        {
            resetTools();
            selectedTool = 4;
        }

        private void PentagonoBtt_Click(object sender, EventArgs e)
        {
            resetTools();
            selectedTool = 2;
        }
    }
}
