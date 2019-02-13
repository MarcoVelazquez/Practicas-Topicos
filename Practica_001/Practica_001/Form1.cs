using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Geometria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Menu.Items.AddRange(new object[] { "Circulo", "Cuadrado" });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputLarRad.Enabled = true;
            InputAncho.Enabled = true;
            InputLarRad.Text = "";
            InputAncho.Text = "";
            if (Menu.SelectedIndex == 0)
            {
                LabLargoRadio.Text = "Radio";
                LabAncho.Visible = false;
                InputAncho.Visible = false;

            }
            else
            {
                LabLargoRadio.Text = "Largo";
                LabAncho.Visible = true;
                InputAncho.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputLarRad.Text != "")
            {
                int AuxLarRad = Convert.ToInt16(InputLarRad.Text);
                if (Menu.SelectedIndex == 0)
                {
                    Controls.Add(DisplayImagen);
                    //DisplayImagen.ImageLocation = @"\Practica_001\Imagenes\Circle.png";
                    DisplayImagen.ImageLocation = @"C:\Users\julianjavier\Desktop\Topicos Avanzados\Practicas\Practica_001\Practica_001\Imagenes";
                    DisplayArea.Text = Convert.ToString(Math.PI * Math.Pow(AuxLarRad, 2));
                    DisplayPerimetro.Text = Convert.ToString(AuxLarRad * 2 * Math.PI);
                }
                else if(InputAncho.Text!="")
                {
                    int AuxAncho = Convert.ToInt16(InputAncho.Text);
                    DisplayArea.Text = Convert.ToString(AuxLarRad * AuxAncho);
                    DisplayPerimetro.Text = Convert.ToString(AuxLarRad * 2 + AuxAncho * 2);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
            //public string ImageLocation {get;set;}
            //Image.FromFile("\Practica_001\Imagenes\Circle.png");
            //Load();
    }

}

