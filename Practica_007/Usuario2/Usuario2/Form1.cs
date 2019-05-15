using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Usuario2
{
    public partial class Form1 : Form
    {
        public static string UserName, Remoteip, SendPort, PasivePort;
        public bool transmitiendo = false, escuchando = false;

        /*La variable 'UserName' será utilizada para guardar el nombre del usuario
         La variable 'Remoteip' será utilizada para guardar la ip a la que se va a conectar el cliente
         La variable 'SendPort' será utilizada para guardar el puerto por donde se enviaran los datos
         La variable 'PasivePort' será utilizada para guardar el puerto por donde se recibiran los datos
         La variable 'transmitiendo será utilizada para comprobar en que estado se encuentra el botón transmitiendo
         La variable 'escuchando' será utilizada para comprobar en que estado se encuentra el botón escuchando*/

        public void GetData()
        {
            UserName = UserNameTxtBox.Text;
            Remoteip = RemoteIpTxtBox.Text;
            SendPort = RemotePortTxtBox.Text;
            PasivePort = LocalPortTxtBox.Text;
        }

        public Form1()
        {
            InitializeComponent();
            LogBox.Enabled = false;
            msg("   -- Bienvenido --");
            Remoteip = "127.0.0.1";
            PasivePort = 8888.ToString(); ;
            SendPort = 8889.ToString();
        }

        public void ConfigDown()
        {
            ConfigGrpBox.Visible = false;
        }

        public void ConfigUp()
        {
            ConfigGrpBox.Visible = true;
        }

        public void MenuDown()
        {
            MenuGrpBox.Visible = false;
        }

        private void EscucharBtt_Click(object sender, EventArgs e)
        {
            EscucharBttStatus();
        }

        private void TransmitirBtt_Click(object sender, EventArgs e)
        {
            TranmitirBttStatus();
        }

        private void CerrarConexionBtt_Click(object sender, EventArgs e)
        {
            msg("   -- Se ha dejado de escuchar y de transmitir, la conexión fue cerrada --");

            TransmitirBtt.Text = "Comenzar a transmitir";
            transmitiendo = false;

            EscucharBtt.Text = "Comenzar a escuchar";
            escuchando = false;
        }

        private void ConfigBtt_Click(object sender, EventArgs e)
        {
            MenuDown();
            ConfigUp();
        }

        private void AceptBtt_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void BackConfigBtt_Click(object sender, EventArgs e)
        {
            MenuUp();
            ConfigDown();
        }

        private void SendBtt_Click(object sender, EventArgs e)
        {
            msg(MsgBox.Text);
        }

        public void MenuUp()
        {
            MenuGrpBox.Visible = true;
        }
        
        public void TranmitirBttStatus()
        {
            if (transmitiendo == false)
            {
                msg("   -- Se ha comenzado a transmitir --");
                TransmitirBtt.Text = "Dejar de transmitir";
                transmitiendo = true;
            }
            else
            {
                msg("   -- Se ha dejado a transmitir --");
                TransmitirBtt.Text = "Comenzar a transmitir";
                transmitiendo = false;
            }
        }

        public void EscucharBttStatus()
        {
            if (escuchando == false)
            {
                msg("   -- Se ha comenzado a escuchar --");
                EscucharBtt.Text = "Dejar de escuchar";
                escuchando = true;
            }
            else
            {
                msg("   -- Se ha dejado de escuchar --");
                EscucharBtt.Text = "Comenzar a escuchar";
                escuchando = false;
            }
        }
        
        public void msg(string mesg)
        {
            LogBox.Text = LogBox.Text + Environment.NewLine + " >> " + mesg;
        }
    }
}
