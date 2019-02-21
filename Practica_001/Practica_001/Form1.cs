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
		//Le da valores iniciales al menu de circulo y cuadrado
            this.Menu.Items.AddRange(new object[] { "Circulo", "Cuadrado", "Triangulo", "Rectangulo"});
            DisplayImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
		//Si detecta cambio en el indice seleccionado va a ejecutar este bloquesote
            InputLarRad.Enabled = true;
            InputAncho.Enabled = true;
            InputLarRad.Text = "";
            InputAncho.Text = "";
            DisplayArea.Text = "";
            DisplayPerimetro.Text = "";
		//Si esta seleccionado el circulo va a cambiar el texto a radio y sera el unico input que aparezca
            if (Menu.SelectedIndex == 0)
            {
                DisplayImagen.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Imagenes\Circle.png");
                LabLargoRadio.Text = "Radio";
                LabAncho.Visible = false;
                InputAncho.Visible = false;
            }
            else if (Menu.SelectedIndex == 1)
            {
                DisplayImagen.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Imagenes\Square.png");
                LabLargoRadio.Text = "Lado";
                LabAncho.Visible = false;
                InputAncho.Visible = false;
            }
            else if (Menu.SelectedIndex == 2)
            {
                DisplayImagen.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Imagenes\Triangle.png");
                LabLargoRadio.Text = "Base";
                LabAncho.Text = "Alto";
                LabAncho.Visible = true;
                InputAncho.Visible = true;
            }
            else if (Menu.SelectedIndex == 3)
            {
                //De lo contrario van a aparecer ambos inputs y textos de largo y ancho para calcular area y perimetro
                DisplayImagen.Image = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Imagenes\Rectangle.png");
                LabLargoRadio.Text = "Largo";
                LabAncho.Visible = true;
                InputAncho.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
		//Va a checar que haya por lo menos un dato puesto, por si no pones nada no crashee
            if (InputLarRad.Text != "")
            {
                
                int AuxLarRad = Convert.ToInt16(InputLarRad.Text);
                if (Menu.SelectedIndex == 0)
                {
			//Si esta seleccionado el circulo va a mostrar el area y perimetro dependiendo del valor que metio el usuario
                    DisplayArea.Text = Convert.ToString(Math.PI * Math.Pow(AuxLarRad, 2));
                    DisplayPerimetro.Text = Convert.ToString(AuxLarRad * 2 * Math.PI);    
                }
                else if (Menu.SelectedIndex == 1)
                {
                    DisplayArea.Text = Convert.ToString(Math.Pow(AuxLarRad,2));
                    DisplayPerimetro.Text = Convert.ToString(AuxLarRad * 4);
                }
                
                else if (Menu.SelectedIndex == 2)
                {
                    if (InputAncho.Text != "")
                    {
                        int AuxAncho = Convert.ToInt16(InputAncho.Text);
                        DisplayArea.Text = Convert.ToString((AuxLarRad * AuxAncho) / 2);
                        DisplayPerimetro.Text = Convert.ToString(AuxLarRad * 3);
                    }
                }
                else if (Menu.SelectedIndex==3)
                {
                    if (InputAncho.Text != "")
                    {
                        //Si el circulo no esta seleccionado entonces es el cuadrado y va a revisar que esten puestos los dos datos para que no crashee
                        int AuxAncho = Convert.ToInt16(InputAncho.Text);
                        DisplayArea.Text = Convert.ToString(AuxLarRad * AuxAncho);
                        DisplayPerimetro.Text = Convert.ToString(AuxLarRad * 2 + AuxAncho * 2);
                    }
                }
            }

        }

    }

}

