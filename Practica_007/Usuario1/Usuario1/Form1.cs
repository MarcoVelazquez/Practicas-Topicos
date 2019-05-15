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

namespace Usuario1
{
    public partial class Form1 : Form
    {
        public static string UserName, Remoteip, RemotePort, LocalPort;
        public bool transmitiendo = false, escuchando = false;


        /*La variable 'UserName' será utilizada para guardar el nombre del usuario
         La variable 'Remoteip' será utilizada para guardar la ip a la que se va a conectar el cliente
         La variable 'SendPort' será utilizada para guardar el puerto por donde se enviaran los datos
         La variable 'PasivePort' será utilizada para guardar el puerto por donde se recibiran los datos
         La variable 'transmitiendo será utilizada para comprobar en que estado se encuentra el botón transmitiendo
         La variable 'escuchando' será utilizada para comprobar en que estado se encuentra el botón escuchando*/
         

        /*El método 'GetData' se encargara de actualizar los datos ingresados en el menu de configuración*/
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
            LocalPort = 8889.ToString(); 
            RemotePort = 8888.ToString();
            UserName = "Usuario 1";
        }
        /*El método 'ConfigDown' se encargara de hacer que el groupbox de la configuración se haga invisible en la GUI*/
        public void ConfigDown()
        {
            ConfigGrpBox.Visible = false;
        }

        /*El método 'ConfigDown' se encargara de hacer que el groupbox de la configuración se haga visible en la GUI*/
        public void ConfigUp()
        {
            ConfigGrpBox.Visible = true;
        }

        /*El método 'ConfigDown' se encargara de hacer que el groupbox del menu se haga invisible en la GUI*/
        public void MenuDown()
        {
            MenuGrpBox.Visible = false;
        }

        /*El método 'ConfigDown' se encargara de hacer que el groupbox del menu se haga visible en la GUI*/
        public void MenuUp()
        {
            MenuGrpBox.Visible = true;
        }

        private void AceptBtt_Click(object sender, EventArgs e)
        {
          /*Se manda a llamar el método 'GetData' en el evento del click en el botn aceptar para actualizar
            los datos que el usuario haya ingresado en el apartado de configuracion*/
            GetData();
        }

        /*El método 'TranmitirBttStatus' es el encargado de revisar el estado del botón transmitir. 
         * Se utiliza la variable 'transmitiendo' como bandera, comenzando con el valor 'false', que
         * indica que el botón no está presionado, y que no se está transmitiendo. Cuando el valor de
         * 'transmitiendo' cambie a 'true', quiere decir que el botón ha sido presionado, y se ha 
         * comenzado a transmitir
           También se mostrara un mensaje cuando se haya comenzado o dejado de transmitir*/
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

        private void SendBtt_Click(object sender, EventArgs e)
        {
            msg(UserName +":" + MsgBox.Text);
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
                escuchando = true;
            }
        }

        private void EscucharBtt_Click(object sender, EventArgs e)
        {
            EscucharBttStatus();
        }

        private void ConfigBtt_Click(object sender, EventArgs e)
        {
            MenuDown();
            ConfigUp();
        }

        private void BackConfigBtt_Click(object sender, EventArgs e)
        {
            MenuUp();
            ConfigDown();
        }

        public void msg(string mesg)
        {
            LogBox.Text = LogBox.Text + Environment.NewLine + " >> " + mesg;
        }
    }
}
