namespace Usuario2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendBtt = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.MsgBox = new System.Windows.Forms.TextBox();
            this.MenuGrpBox = new System.Windows.Forms.GroupBox();
            this.TransmitirBtt = new System.Windows.Forms.Button();
            this.CerrarConexionBtt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigBtt = new System.Windows.Forms.Button();
            this.EscucharBtt = new System.Windows.Forms.Button();
            this.ConfigGrpBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.BackConfigBtt = new System.Windows.Forms.Button();
            this.LocalPortLbl = new System.Windows.Forms.Label();
            this.ConfigLbl = new System.Windows.Forms.Label();
            this.RemotePortLbl = new System.Windows.Forms.Label();
            this.AceptBtt = new System.Windows.Forms.Button();
            this.RemoteIpLbl = new System.Windows.Forms.Label();
            this.LocalPortTxtBox = new System.Windows.Forms.TextBox();
            this.RemoteIpTxtBox = new System.Windows.Forms.TextBox();
            this.RemotePortTxtBox = new System.Windows.Forms.TextBox();
            this.MenuGrpBox.SuspendLayout();
            this.ConfigGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendBtt
            // 
            this.SendBtt.Location = new System.Drawing.Point(715, 399);
            this.SendBtt.Name = "SendBtt";
            this.SendBtt.Size = new System.Drawing.Size(75, 31);
            this.SendBtt.TabIndex = 19;
            this.SendBtt.Text = "Enviar";
            this.SendBtt.UseVisualStyleBackColor = true;
            this.SendBtt.Click += new System.EventHandler(this.SendBtt_Click);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(334, 36);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(457, 358);
            this.LogBox.TabIndex = 18;
            // 
            // MsgBox
            // 
            this.MsgBox.Location = new System.Drawing.Point(334, 400);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(374, 20);
            this.MsgBox.TabIndex = 17;
            // 
            // MenuGrpBox
            // 
            this.MenuGrpBox.Controls.Add(this.TransmitirBtt);
            this.MenuGrpBox.Controls.Add(this.CerrarConexionBtt);
            this.MenuGrpBox.Controls.Add(this.label1);
            this.MenuGrpBox.Controls.Add(this.ConfigBtt);
            this.MenuGrpBox.Controls.Add(this.EscucharBtt);
            this.MenuGrpBox.Location = new System.Drawing.Point(9, 20);
            this.MenuGrpBox.Name = "MenuGrpBox";
            this.MenuGrpBox.Size = new System.Drawing.Size(319, 390);
            this.MenuGrpBox.TabIndex = 16;
            this.MenuGrpBox.TabStop = false;
            // 
            // TransmitirBtt
            // 
            this.TransmitirBtt.Location = new System.Drawing.Point(77, 161);
            this.TransmitirBtt.Name = "TransmitirBtt";
            this.TransmitirBtt.Size = new System.Drawing.Size(162, 34);
            this.TransmitirBtt.TabIndex = 4;
            this.TransmitirBtt.Text = "Comenzar a transmitir";
            this.TransmitirBtt.UseVisualStyleBackColor = true;
            this.TransmitirBtt.Click += new System.EventHandler(this.TransmitirBtt_Click);
            // 
            // CerrarConexionBtt
            // 
            this.CerrarConexionBtt.Location = new System.Drawing.Point(77, 221);
            this.CerrarConexionBtt.Name = "CerrarConexionBtt";
            this.CerrarConexionBtt.Size = new System.Drawing.Size(162, 34);
            this.CerrarConexionBtt.TabIndex = 3;
            this.CerrarConexionBtt.Text = "Cerrar conexión";
            this.CerrarConexionBtt.UseVisualStyleBackColor = true;
            this.CerrarConexionBtt.Click += new System.EventHandler(this.CerrarConexionBtt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat asícrono";
            // 
            // ConfigBtt
            // 
            this.ConfigBtt.Location = new System.Drawing.Point(77, 281);
            this.ConfigBtt.Name = "ConfigBtt";
            this.ConfigBtt.Size = new System.Drawing.Size(162, 34);
            this.ConfigBtt.TabIndex = 1;
            this.ConfigBtt.Text = "Configuración";
            this.ConfigBtt.UseVisualStyleBackColor = true;
            this.ConfigBtt.Click += new System.EventHandler(this.ConfigBtt_Click);
            // 
            // EscucharBtt
            // 
            this.EscucharBtt.Location = new System.Drawing.Point(77, 101);
            this.EscucharBtt.Name = "EscucharBtt";
            this.EscucharBtt.Size = new System.Drawing.Size(162, 34);
            this.EscucharBtt.TabIndex = 0;
            this.EscucharBtt.Text = "Comenzar a escuchar";
            this.EscucharBtt.UseVisualStyleBackColor = true;
            this.EscucharBtt.Click += new System.EventHandler(this.EscucharBtt_Click);
            // 
            // ConfigGrpBox
            // 
            this.ConfigGrpBox.Controls.Add(this.label2);
            this.ConfigGrpBox.Controls.Add(this.UserNameTxtBox);
            this.ConfigGrpBox.Controls.Add(this.BackConfigBtt);
            this.ConfigGrpBox.Controls.Add(this.LocalPortLbl);
            this.ConfigGrpBox.Controls.Add(this.ConfigLbl);
            this.ConfigGrpBox.Controls.Add(this.RemotePortLbl);
            this.ConfigGrpBox.Controls.Add(this.AceptBtt);
            this.ConfigGrpBox.Controls.Add(this.RemoteIpLbl);
            this.ConfigGrpBox.Controls.Add(this.LocalPortTxtBox);
            this.ConfigGrpBox.Controls.Add(this.RemoteIpTxtBox);
            this.ConfigGrpBox.Controls.Add(this.RemotePortTxtBox);
            this.ConfigGrpBox.Location = new System.Drawing.Point(9, 20);
            this.ConfigGrpBox.Name = "ConfigGrpBox";
            this.ConfigGrpBox.Size = new System.Drawing.Size(319, 401);
            this.ConfigGrpBox.TabIndex = 15;
            this.ConfigGrpBox.TabStop = false;
            this.ConfigGrpBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre del usuario";
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.Location = new System.Drawing.Point(112, 51);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameTxtBox.TabIndex = 10;
            // 
            // BackConfigBtt
            // 
            this.BackConfigBtt.Location = new System.Drawing.Point(96, 241);
            this.BackConfigBtt.Name = "BackConfigBtt";
            this.BackConfigBtt.Size = new System.Drawing.Size(125, 23);
            this.BackConfigBtt.TabIndex = 9;
            this.BackConfigBtt.Text = "Volver al menu";
            this.BackConfigBtt.UseVisualStyleBackColor = true;
            this.BackConfigBtt.Click += new System.EventHandler(this.BackConfigBtt_Click);
            // 
            // LocalPortLbl
            // 
            this.LocalPortLbl.AutoSize = true;
            this.LocalPortLbl.Location = new System.Drawing.Point(10, 174);
            this.LocalPortLbl.Name = "LocalPortLbl";
            this.LocalPortLbl.Size = new System.Drawing.Size(54, 13);
            this.LocalPortLbl.TabIndex = 5;
            this.LocalPortLbl.Text = "Local port";
            // 
            // ConfigLbl
            // 
            this.ConfigLbl.AutoSize = true;
            this.ConfigLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigLbl.Location = new System.Drawing.Point(0, 16);
            this.ConfigLbl.Name = "ConfigLbl";
            this.ConfigLbl.Size = new System.Drawing.Size(83, 15);
            this.ConfigLbl.TabIndex = 8;
            this.ConfigLbl.Text = "Configuración";
            // 
            // RemotePortLbl
            // 
            this.RemotePortLbl.AutoSize = true;
            this.RemotePortLbl.Location = new System.Drawing.Point(10, 134);
            this.RemotePortLbl.Name = "RemotePortLbl";
            this.RemotePortLbl.Size = new System.Drawing.Size(65, 13);
            this.RemotePortLbl.TabIndex = 4;
            this.RemotePortLbl.Text = "Remote port";
            // 
            // AceptBtt
            // 
            this.AceptBtt.Location = new System.Drawing.Point(121, 211);
            this.AceptBtt.Name = "AceptBtt";
            this.AceptBtt.Size = new System.Drawing.Size(75, 23);
            this.AceptBtt.TabIndex = 7;
            this.AceptBtt.Text = "Aceptar";
            this.AceptBtt.UseVisualStyleBackColor = true;
            this.AceptBtt.Click += new System.EventHandler(this.AceptBtt_Click);
            // 
            // RemoteIpLbl
            // 
            this.RemoteIpLbl.AutoSize = true;
            this.RemoteIpLbl.Location = new System.Drawing.Point(10, 94);
            this.RemoteIpLbl.Name = "RemoteIpLbl";
            this.RemoteIpLbl.Size = new System.Drawing.Size(55, 13);
            this.RemoteIpLbl.TabIndex = 3;
            this.RemoteIpLbl.Text = "Remote ip";
            // 
            // LocalPortTxtBox
            // 
            this.LocalPortTxtBox.Location = new System.Drawing.Point(112, 171);
            this.LocalPortTxtBox.Name = "LocalPortTxtBox";
            this.LocalPortTxtBox.Size = new System.Drawing.Size(100, 20);
            this.LocalPortTxtBox.TabIndex = 2;
            // 
            // RemoteIpTxtBox
            // 
            this.RemoteIpTxtBox.Location = new System.Drawing.Point(112, 91);
            this.RemoteIpTxtBox.Name = "RemoteIpTxtBox";
            this.RemoteIpTxtBox.Size = new System.Drawing.Size(100, 20);
            this.RemoteIpTxtBox.TabIndex = 0;
            // 
            // RemotePortTxtBox
            // 
            this.RemotePortTxtBox.Location = new System.Drawing.Point(112, 131);
            this.RemotePortTxtBox.Name = "RemotePortTxtBox";
            this.RemotePortTxtBox.Size = new System.Drawing.Size(100, 20);
            this.RemotePortTxtBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendBtt);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.ConfigGrpBox);
            this.Controls.Add(this.MenuGrpBox);
            this.Name = "Form1";
            this.Text = "Usuario2";
            this.MenuGrpBox.ResumeLayout(false);
            this.MenuGrpBox.PerformLayout();
            this.ConfigGrpBox.ResumeLayout(false);
            this.ConfigGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBtt;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox MsgBox;
        private System.Windows.Forms.GroupBox MenuGrpBox;
        private System.Windows.Forms.Button TransmitirBtt;
        private System.Windows.Forms.Button CerrarConexionBtt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfigBtt;
        private System.Windows.Forms.Button EscucharBtt;
        private System.Windows.Forms.GroupBox ConfigGrpBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.Button BackConfigBtt;
        private System.Windows.Forms.Label LocalPortLbl;
        private System.Windows.Forms.Label ConfigLbl;
        private System.Windows.Forms.Label RemotePortLbl;
        private System.Windows.Forms.Button AceptBtt;
        private System.Windows.Forms.Label RemoteIpLbl;
        private System.Windows.Forms.TextBox LocalPortTxtBox;
        private System.Windows.Forms.TextBox RemoteIpTxtBox;
        private System.Windows.Forms.TextBox RemotePortTxtBox;
    }
}

