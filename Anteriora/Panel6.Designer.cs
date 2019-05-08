namespace Anteriora
{
    partial class Panel6
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxWyjscie = new System.Windows.Forms.PictureBox();
            this.pictureBoxRuchOkna = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxKamiennyMiecz = new System.Windows.Forms.PictureBox();
            this.labelUbraniaMieszkancowIlosc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLozkoIlosc = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWyjscie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuchOkna)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamiennyMiecz)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWyjscie
            // 
            this.pictureBoxWyjscie.BackColor = System.Drawing.Color.Red;
            this.pictureBoxWyjscie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWyjscie.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxWyjscie.Name = "pictureBoxWyjscie";
            this.pictureBoxWyjscie.Size = new System.Drawing.Size(105, 10);
            this.pictureBoxWyjscie.TabIndex = 22;
            this.pictureBoxWyjscie.TabStop = false;
            this.pictureBoxWyjscie.Click += new System.EventHandler(this.PictureBoxWyjscie_Click);
            // 
            // pictureBoxRuchOkna
            // 
            this.pictureBoxRuchOkna.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxRuchOkna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRuchOkna.Location = new System.Drawing.Point(0, 78);
            this.pictureBoxRuchOkna.Name = "pictureBoxRuchOkna";
            this.pictureBoxRuchOkna.Size = new System.Drawing.Size(105, 10);
            this.pictureBoxRuchOkna.TabIndex = 23;
            this.pictureBoxRuchOkna.TabStop = false;
            this.pictureBoxRuchOkna.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxRuchOkna_MouseDown);
            this.pictureBoxRuchOkna.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxRuchOkna_MouseMove);
            this.pictureBoxRuchOkna.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxRuchOkna_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBoxKamiennyMiecz);
            this.panel1.Controls.Add(this.labelUbraniaMieszkancowIlosc);
            this.panel1.Location = new System.Drawing.Point(5, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 25);
            this.panel1.TabIndex = 24;
            // 
            // pictureBoxKamiennyMiecz
            // 
            this.pictureBoxKamiennyMiecz.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKamiennyMiecz.BackgroundImage = global::Anteriora.Properties.Resources.ubrania_mieszkanców;
            this.pictureBoxKamiennyMiecz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxKamiennyMiecz.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxKamiennyMiecz.Name = "pictureBoxKamiennyMiecz";
            this.pictureBoxKamiennyMiecz.Size = new System.Drawing.Size(25, 20);
            this.pictureBoxKamiennyMiecz.TabIndex = 0;
            this.pictureBoxKamiennyMiecz.TabStop = false;
            // 
            // labelUbraniaMieszkancowIlosc
            // 
            this.labelUbraniaMieszkancowIlosc.AutoSize = true;
            this.labelUbraniaMieszkancowIlosc.BackColor = System.Drawing.Color.Transparent;
            this.labelUbraniaMieszkancowIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUbraniaMieszkancowIlosc.Location = new System.Drawing.Point(32, 4);
            this.labelUbraniaMieszkancowIlosc.Name = "labelUbraniaMieszkancowIlosc";
            this.labelUbraniaMieszkancowIlosc.Size = new System.Drawing.Size(148, 18);
            this.labelUbraniaMieszkancowIlosc.TabIndex = 1;
            this.labelUbraniaMieszkancowIlosc.Text = "ubraniaMieszkancow";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labelLozkoIlosc);
            this.panel2.Location = new System.Drawing.Point(5, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 25);
            this.panel2.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Anteriora.Properties.Resources.łóżko;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelLozkoIlosc
            // 
            this.labelLozkoIlosc.AutoSize = true;
            this.labelLozkoIlosc.BackColor = System.Drawing.Color.Transparent;
            this.labelLozkoIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLozkoIlosc.Location = new System.Drawing.Point(32, 4);
            this.labelLozkoIlosc.Name = "labelLozkoIlosc";
            this.labelLozkoIlosc.Size = new System.Drawing.Size(45, 18);
            this.labelLozkoIlosc.TabIndex = 1;
            this.labelLozkoIlosc.Text = "lozko";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Panel6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(105, 88);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxRuchOkna);
            this.Controls.Add(this.pictureBoxWyjscie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1815, 815);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(105, 88);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(105, 88);
            this.Name = "Panel6";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Panel6";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWyjscie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRuchOkna)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamiennyMiecz)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWyjscie;
        private System.Windows.Forms.PictureBox pictureBoxRuchOkna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxKamiennyMiecz;
        private System.Windows.Forms.Label labelUbraniaMieszkancowIlosc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLozkoIlosc;
        private System.Windows.Forms.Timer timer;
    }
}