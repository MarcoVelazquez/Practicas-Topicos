namespace Practica_008
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
            this.OperacionCmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OperacionCmbBox
            // 
            this.OperacionCmbBox.FormattingEnabled = true;
            this.OperacionCmbBox.Location = new System.Drawing.Point(155, 179);
            this.OperacionCmbBox.Name = "OperacionCmbBox";
            this.OperacionCmbBox.Size = new System.Drawing.Size(121, 21);
            this.OperacionCmbBox.TabIndex = 0;
            this.OperacionCmbBox.SelectedIndexChanged += new System.EventHandler(this.OperacionCmbBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OperacionCmbBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox OperacionCmbBox;
    }
}

