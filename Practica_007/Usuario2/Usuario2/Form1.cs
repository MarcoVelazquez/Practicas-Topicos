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
        public static string UserName, Remoteip, RemotePort, LocalPort;
        public bool transmitiendo = false, escuchando = false;

        TcpClient LocalSocket = new TcpClient();
        TcpListener ServerSocket;
        NetworkStream serverStream;

        public void Transmitir()
        {
            LocalSocket = new System.Net.Sockets.TcpClient();

            LocalSocket.Connect(Remoteip, Int32.Parse(LocalPort));
            serverStream = LocalSocket.GetStream();
        }

        public void Escuchar()
        {
            ServerSocket = new TcpListener(Int32.Parse(RemotePort));
            ServerSocket.Start();

        }


        public void GetData()
        {
            UserName = UserNameTxtBox.Text;
            Remoteip = RemoteIpTxtBox.Text;
            RemotePort = RemotePortTxtBox.Text;
            LocalPort = LocalPortTxtBox.Text;
        }



        public Form1()
        {

            InitializeComponent();
            LogBox.Enabled = false;
            msg("   -- Bienvenido --");
            Remoteip = "127.0.0.1";
            LocalPort = 8888.ToString(); ;
            RemotePort = 8889.ToString();



        }

        public void ChatDown()
        {
            //ChatGrpBox.Visible = false;
        }

        public void ChatUp()
        {
            //ChatGrpBox.Visible = true;
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
            LocalSocket.Close();
            serverStream.Close();

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
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(MsgBox.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[10025];
            serverStream.Read(inStream, 0, 50);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);

            string[] separado = returndata.Split('@');
            for (int i = 0; i < separado.Length; i++)
                msg(separado[i]);

            MsgBox.Text = "";
            MsgBox.Focus();
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
                Transmitir();
            }
            else
            {
                msg("   -- Se ha dejado a transmitir --");
                TransmitirBtt.Text = "Comenzar a transmitir";
                transmitiendo = false;
                LocalSocket.Close();
            }
        }

        

        

        public void EscucharBttStatus()
        {
            if (escuchando == false)
            {
                msg("   -- Se ha comenzado a escuchar --");
                EscucharBtt.Text = "Dejar de escuchar";
                escuchando = true;
                Escuchar();
            }
            else
            {
                msg("   -- Se ha dejado de escuchar --");
                EscucharBtt.Text = "Comenzar a escuchar";
                escuchando = true;
                ServerSocket.Stop();
            }
        }

        

        

        

        public void msg(string mesg)
        {
            LogBox.Text = LogBox.Text + Environment.NewLine + " >> " + mesg;
        }

    }
}

