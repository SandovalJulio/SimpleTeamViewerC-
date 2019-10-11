namespace RemoteScreen
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
            this.components = new System.ComponentModel.Container();
            this.pic_Screen = new System.Windows.Forms.PictureBox();
            this.btn_ver_pantalla = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.outfullscreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Screen)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Screen
            // 
            this.pic_Screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Screen.Location = new System.Drawing.Point(12, 41);
            this.pic_Screen.Name = "pic_Screen";
            this.pic_Screen.Size = new System.Drawing.Size(640, 360);
            this.pic_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Screen.TabIndex = 0;
            this.pic_Screen.TabStop = false;
            this.pic_Screen.DoubleClick += new System.EventHandler(this.Outfullscreen_Click);
            // 
            // btn_ver_pantalla
            // 
            this.btn_ver_pantalla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ver_pantalla.Location = new System.Drawing.Point(118, 9);
            this.btn_ver_pantalla.Name = "btn_ver_pantalla";
            this.btn_ver_pantalla.Size = new System.Drawing.Size(75, 23);
            this.btn_ver_pantalla.TabIndex = 1;
            this.btn_ver_pantalla.Text = "Ver pantalla";
            this.btn_ver_pantalla.UseVisualStyleBackColor = true;
            this.btn_ver_pantalla.Click += new System.EventHandler(this.Btn_ver_pantalla_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_ip.Location = new System.Drawing.Point(12, 11);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 20);
            this.txt_ip.TabIndex = 2;
            this.txt_ip.Text = "Dirección IP";
            this.txt_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ip.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.txt_ip.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(199, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver frames";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fullscreen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // outfullscreen
            // 
            this.outfullscreen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.outfullscreen.Location = new System.Drawing.Point(414, 8);
            this.outfullscreen.Name = "outfullscreen";
            this.outfullscreen.Size = new System.Drawing.Size(75, 23);
            this.outfullscreen.TabIndex = 7;
            this.outfullscreen.Text = "Fullscreen";
            this.outfullscreen.UseVisualStyleBackColor = true;
            this.outfullscreen.Visible = false;
            this.outfullscreen.Click += new System.EventHandler(this.Outfullscreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.outfullscreen;
            this.ClientSize = new System.Drawing.Size(665, 416);
            this.Controls.Add(this.outfullscreen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.btn_ver_pantalla);
            this.Controls.Add(this.pic_Screen);
            this.Name = "Form1";
            this.Text = "Espía de pantalla remota";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Screen;
        private System.Windows.Forms.Button btn_ver_pantalla;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button outfullscreen;
    }
}

