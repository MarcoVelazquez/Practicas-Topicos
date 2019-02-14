namespace Geometria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabArea = new System.Windows.Forms.Label();
            this.LabPerimetro = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.ComboBox();
            this.DisplayImagen = new System.Windows.Forms.PictureBox();
            this.InputLarRad = new System.Windows.Forms.TextBox();
            this.InputAncho = new System.Windows.Forms.TextBox();
            this.LabLargoRadio = new System.Windows.Forms.Label();
            this.LabAncho = new System.Windows.Forms.Label();
            this.DisplayPerimetro = new System.Windows.Forms.TextBox();
            this.DisplayArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LabArea
            // 
            this.LabArea.AutoSize = true;
            this.LabArea.Location = new System.Drawing.Point(348, 180);
            this.LabArea.Name = "LabArea";
            this.LabArea.Size = new System.Drawing.Size(29, 13);
            this.LabArea.TabIndex = 0;
            this.LabArea.Text = "Área";
            this.LabArea.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabPerimetro
            // 
            this.LabPerimetro.AutoSize = true;
            this.LabPerimetro.Location = new System.Drawing.Point(348, 209);
            this.LabPerimetro.Name = "LabPerimetro";
            this.LabPerimetro.Size = new System.Drawing.Size(51, 13);
            this.LabPerimetro.TabIndex = 1;
            this.LabPerimetro.Text = "Perimetro";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(442, 248);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 46);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.Menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Menu.FormattingEnabled = true;
            this.Menu.Location = new System.Drawing.Point(39, 26);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(278, 21);
            this.Menu.TabIndex = 3;
            this.Menu.SelectedIndexChanged += new System.EventHandler(this.Menu_SelectedIndexChanged);
            // 
            // DisplayImagen
            // 
            this.DisplayImagen.BackColor = System.Drawing.Color.White;
            this.DisplayImagen.Location = new System.Drawing.Point(39, 72);
            this.DisplayImagen.Name = "DisplayImagen";
            this.DisplayImagen.Size = new System.Drawing.Size(277, 221);
            this.DisplayImagen.TabIndex = 4;
            this.DisplayImagen.TabStop = false;
            this.DisplayImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InputLarRad
            // 
            this.InputLarRad.Enabled = false;
            this.InputLarRad.Location = new System.Drawing.Point(411, 72);
            this.InputLarRad.Name = "InputLarRad";
            this.InputLarRad.Size = new System.Drawing.Size(117, 20);
            this.InputLarRad.TabIndex = 5;
            // 
            // InputAncho
            // 
            this.InputAncho.Enabled = false;
            this.InputAncho.Location = new System.Drawing.Point(411, 106);
            this.InputAncho.Name = "InputAncho";
            this.InputAncho.Size = new System.Drawing.Size(117, 20);
            this.InputAncho.TabIndex = 6;
            // 
            // LabLargoRadio
            // 
            this.LabLargoRadio.AutoSize = true;
            this.LabLargoRadio.Location = new System.Drawing.Point(348, 75);
            this.LabLargoRadio.Name = "LabLargoRadio";
            this.LabLargoRadio.Size = new System.Drawing.Size(34, 13);
            this.LabLargoRadio.TabIndex = 7;
            this.LabLargoRadio.Text = "Largo";
            // 
            // LabAncho
            // 
            this.LabAncho.AutoSize = true;
            this.LabAncho.Location = new System.Drawing.Point(348, 109);
            this.LabAncho.Name = "LabAncho";
            this.LabAncho.Size = new System.Drawing.Size(38, 13);
            this.LabAncho.TabIndex = 8;
            this.LabAncho.Text = "Ancho";
            // 
            // DisplayPerimetro
            // 
            this.DisplayPerimetro.Enabled = false;
            this.DisplayPerimetro.Location = new System.Drawing.Point(411, 206);
            this.DisplayPerimetro.Name = "DisplayPerimetro";
            this.DisplayPerimetro.Size = new System.Drawing.Size(117, 20);
            this.DisplayPerimetro.TabIndex = 9;
            // 
            // DisplayArea
            // 
            this.DisplayArea.Enabled = false;
            this.DisplayArea.Location = new System.Drawing.Point(411, 177);
            this.DisplayArea.Name = "DisplayArea";
            this.DisplayArea.Size = new System.Drawing.Size(117, 20);
            this.DisplayArea.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 306);
            this.Controls.Add(this.DisplayArea);
            this.Controls.Add(this.DisplayPerimetro);
            this.Controls.Add(this.LabAncho);
            this.Controls.Add(this.LabLargoRadio);
            this.Controls.Add(this.InputAncho);
            this.Controls.Add(this.InputLarRad);
            this.Controls.Add(this.DisplayImagen);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.LabPerimetro);
            this.Controls.Add(this.LabArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica_001";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabArea;
        private System.Windows.Forms.Label LabPerimetro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox Menu;
        private System.Windows.Forms.PictureBox DisplayImagen;
        private System.Windows.Forms.TextBox InputLarRad;
        private System.Windows.Forms.TextBox InputAncho;
        private System.Windows.Forms.Label LabLargoRadio;
        private System.Windows.Forms.Label LabAncho;
        private System.Windows.Forms.TextBox DisplayPerimetro;
        private System.Windows.Forms.TextBox DisplayArea;
    }
}

