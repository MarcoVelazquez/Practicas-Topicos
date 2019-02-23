using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica_002
{
    public partial class Form1 : Form
    {
        public bool Turno=true, Victorioso=false;

        public string[] Tab = new string[9];
        public Form1()
        {
            InitializeComponent();
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button9);
            for (int i = 0; i < Tab.Length; i++)
            {
                Tab[i] = "-";
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (Turno)
            {
                btn.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Imagenes\X.jpg");
                Tab[Convert.ToInt16(btn.Text)] = "x";
                Turno = false;
                btn.Text = "";
            }
            else
            {
                btn.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\Imagenes\Circle.png");
                Tab[Convert.ToInt16(btn.Text)] = "o";
                Turno = true;
                btn.Text = "";
            }
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Enabled = false;
            Victoria();

        }

        private void Reinicio_Click(object sender, EventArgs e)
        {
            if (Victorioso == false)
            {
                lblEmpate.Text = Convert.ToString(Convert.ToInt16(lblEmpate.Text) + 1);
            }
            else
            {
                Victorioso = false;
            }
            
            groupBox1.Enabled = true;
            int n = 0;
            foreach (Button btn in groupBox1.Controls)
            {
                btn.Enabled = true;
                btn.BackgroundImage = null;
                btn.Text = Convert.ToString(n);
                Tab[n] = "-";
                n++;
            }
        }
        public void CambioScore(bool Turno)
        {
            if (Turno)
            {
                lblOVictoria.Text = Convert.ToString(Convert.ToInt16(lblOVictoria.Text) + 1);
            }
            else
            {
                lblXVictoria.Text = Convert.ToString(Convert.ToInt16(lblXVictoria.Text) + 1);
            }
            Victorioso = true;
            groupBox1.Enabled = false;
        }
        public void Victoria()
        {
            if (Tab[0] == Tab[1] && Tab[1] == Tab[2])
            {
                if (Tab[0] == "x" || Tab[0]=="o")
                {
                    CambioScore(Turno);
                }
            }
            if (Tab[3] == Tab[4] && Tab[4] == Tab[5])
            {
                if (Tab[3] == "x" || Tab[3] == "o")
                {
                    CambioScore(Turno);
                }
            }
            if (Tab[6]==Tab[7] && Tab[7]==Tab[8])
            {
                if (Tab[6] == "x" || Tab[6] == "o")
                {
                    CambioScore(Turno);
                }
            }
            if (Tab[0] == Tab[3] && Tab[3] == Tab[6])
            {
                if (Tab[6] == "x" || Tab[6] == "o")
                {
                    CambioScore(Turno);
                }
            }
            if (Tab[1] == Tab[7] && Tab[7] == Tab[4])
            {
                if (Tab[1] == "x" || Tab[1] == "o")
                {
                    CambioScore(Turno);
                }
            }
            if (Tab[2] == Tab[5] && Tab[5] == Tab[8])
            {
                if (Tab[2] == "x" || Tab[2] == "o")
                {
                    CambioScore(Turno);
                }
            }
            if (Tab[0] == Tab[4] && Tab[4] == Tab[8])
            {
                if (Tab[0] == "x" || Tab[0] == "o")
                {
                    CambioScore(Turno);
                }
            }
            if (Tab[2] == Tab[4] && Tab[4] == Tab[6])
            {
                if (Tab[6] == "x" || Tab[6] == "o")
                
                    CambioScore(Turno);
                }
            }
        }
    }
