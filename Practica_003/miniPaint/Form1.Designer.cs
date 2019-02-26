namespace miniPaint
{
    partial class GrosorLbl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawArea = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.toolBox = new System.Windows.Forms.GroupBox();
            this.SoloLapizBtt = new System.Windows.Forms.Button();
            this.DodecagonoBtt = new System.Windows.Forms.Button();
            this.PentagonoBtt = new System.Windows.Forms.Button();
            this.CuadradoBtt = new System.Windows.Forms.Button();
            this.RectánguloBtt = new System.Windows.Forms.Button();
            this.TriánguloBtt = new System.Windows.Forms.Button();
            this.ElipseBtt = new System.Windows.Forms.Button();
            this.ColorBtt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrosorCmbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            this.toolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawArea
            // 
            this.drawArea.BackColor = System.Drawing.Color.White;
            this.drawArea.Location = new System.Drawing.Point(-1, 68);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(646, 405);
            this.drawArea.TabIndex = 0;
            this.drawArea.TabStop = false;
            this.drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawArea_Paint);
            this.drawArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseClick);
            this.drawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseDown);
            this.drawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseMove_1);
            this.drawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseUp);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(349, 39);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // toolBox
            // 
            this.toolBox.BackColor = System.Drawing.Color.Transparent;
            this.toolBox.Controls.Add(this.SoloLapizBtt);
            this.toolBox.Controls.Add(this.DodecagonoBtt);
            this.toolBox.Controls.Add(this.PentagonoBtt);
            this.toolBox.Controls.Add(this.CuadradoBtt);
            this.toolBox.Controls.Add(this.RectánguloBtt);
            this.toolBox.Controls.Add(this.TriánguloBtt);
            this.toolBox.Controls.Add(this.ElipseBtt);
            this.toolBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toolBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolBox.Location = new System.Drawing.Point(12, 3);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(331, 59);
            this.toolBox.TabIndex = 2;
            this.toolBox.TabStop = false;
            this.toolBox.Text = "Tools";
            // 
            // SoloLapizBtt
            // 
            this.SoloLapizBtt.Location = new System.Drawing.Point(278, 19);
            this.SoloLapizBtt.Name = "SoloLapizBtt";
            this.SoloLapizBtt.Size = new System.Drawing.Size(40, 40);
            this.SoloLapizBtt.TabIndex = 6;
            this.SoloLapizBtt.Text = "SoloLapiz";
            this.SoloLapizBtt.UseVisualStyleBackColor = true;
            this.SoloLapizBtt.Click += new System.EventHandler(this.SoloLapizBtt_Click);
            // 
            // DodecagonoBtt
            // 
            this.DodecagonoBtt.Location = new System.Drawing.Point(94, 19);
            this.DodecagonoBtt.Name = "DodecagonoBtt";
            this.DodecagonoBtt.Size = new System.Drawing.Size(40, 40);
            this.DodecagonoBtt.TabIndex = 5;
            this.DodecagonoBtt.Text = "Dodecagono";
            this.DodecagonoBtt.UseVisualStyleBackColor = true;
            this.DodecagonoBtt.Click += new System.EventHandler(this.DodecagonoBtt_Click);
            // 
            // PentagonoBtt
            // 
            this.PentagonoBtt.Location = new System.Drawing.Point(232, 19);
            this.PentagonoBtt.Name = "PentagonoBtt";
            this.PentagonoBtt.Size = new System.Drawing.Size(40, 40);
            this.PentagonoBtt.TabIndex = 4;
            this.PentagonoBtt.Text = "Pentagono";
            this.PentagonoBtt.UseVisualStyleBackColor = true;
            this.PentagonoBtt.Click += new System.EventHandler(this.PentagonoBtt_Click);
            // 
            // CuadradoBtt
            // 
            this.CuadradoBtt.Location = new System.Drawing.Point(52, 19);
            this.CuadradoBtt.Name = "CuadradoBtt";
            this.CuadradoBtt.Size = new System.Drawing.Size(40, 40);
            this.CuadradoBtt.TabIndex = 3;
            this.CuadradoBtt.Text = "Cuadrado";
            this.CuadradoBtt.UseVisualStyleBackColor = true;
            this.CuadradoBtt.Click += new System.EventHandler(this.button3_Click);
            // 
            // RectánguloBtt
            // 
            this.RectánguloBtt.Location = new System.Drawing.Point(6, 19);
            this.RectánguloBtt.Name = "RectánguloBtt";
            this.RectánguloBtt.Size = new System.Drawing.Size(40, 40);
            this.RectánguloBtt.TabIndex = 1;
            this.RectánguloBtt.Text = "Rectángulo";
            this.RectánguloBtt.UseVisualStyleBackColor = true;
            this.RectánguloBtt.Click += new System.EventHandler(this.rectButton_Click);
            // 
            // TriánguloBtt
            // 
            this.TriánguloBtt.Location = new System.Drawing.Point(186, 19);
            this.TriánguloBtt.Name = "TriánguloBtt";
            this.TriánguloBtt.Size = new System.Drawing.Size(40, 40);
            this.TriánguloBtt.TabIndex = 2;
            this.TriánguloBtt.Text = "Triángulo";
            this.TriánguloBtt.UseVisualStyleBackColor = true;
            this.TriánguloBtt.Click += new System.EventHandler(this.button4_Click);
            // 
            // ElipseBtt
            // 
            this.ElipseBtt.Location = new System.Drawing.Point(140, 19);
            this.ElipseBtt.Name = "ElipseBtt";
            this.ElipseBtt.Size = new System.Drawing.Size(40, 40);
            this.ElipseBtt.TabIndex = 0;
            this.ElipseBtt.Text = "Elipse";
            this.ElipseBtt.UseVisualStyleBackColor = true;
            this.ElipseBtt.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // ColorBtt
            // 
            this.ColorBtt.Location = new System.Drawing.Point(349, 12);
            this.ColorBtt.Name = "ColorBtt";
            this.ColorBtt.Size = new System.Drawing.Size(75, 23);
            this.ColorBtt.TabIndex = 3;
            this.ColorBtt.Text = "Color";
            this.ColorBtt.UseVisualStyleBackColor = true;
            this.ColorBtt.Click += new System.EventHandler(this.ColorBtt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cambiar grosor";
            // 
            // GrosorCmbx
            // 
            this.GrosorCmbx.FormattingEnabled = true;
            this.GrosorCmbx.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.GrosorCmbx.Location = new System.Drawing.Point(445, 25);
            this.GrosorCmbx.Name = "GrosorCmbx";
            this.GrosorCmbx.Size = new System.Drawing.Size(86, 21);
            this.GrosorCmbx.TabIndex = 6;
            this.GrosorCmbx.SelectedIndexChanged += new System.EventHandler(this.GrosorCmbx_SelectedIndexChanged);
            this.GrosorCmbx.Click += new System.EventHandler(this.GrosorCmbx_Click);
            // 
            // GrosorLbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 469);
            this.Controls.Add(this.GrosorCmbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorBtt);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawArea);
            this.Name = "GrosorLbl";
            this.Text = "Practica_003";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            this.toolBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawArea;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox toolBox;
        private System.Windows.Forms.Button CuadradoBtt;
        private System.Windows.Forms.Button TriánguloBtt;
        private System.Windows.Forms.Button RectánguloBtt;
        private System.Windows.Forms.Button ElipseBtt;
        private System.Windows.Forms.Button DodecagonoBtt;
        private System.Windows.Forms.Button PentagonoBtt;
        private System.Windows.Forms.Button SoloLapizBtt;
        private System.Windows.Forms.Button ColorBtt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GrosorCmbx;
    }
}

