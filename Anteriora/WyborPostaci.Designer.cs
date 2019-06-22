namespace Anteriora
{
    partial class WyborPostaci
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
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.buttonDalej = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxNazwaPostaci = new ZBobb.AlphaBlendTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelAtrybuty = new System.Windows.Forms.Label();
            this.pictureBoxPostacLewo = new System.Windows.Forms.PictureBox();
            this.buttonWojownik = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLogin = new ZBobb.AlphaBlendTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxHaslo = new ZBobb.AlphaBlendTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostacLewo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonPowrot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPowrot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPowrot.Location = new System.Drawing.Point(98, 501);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(271, 73);
            this.buttonPowrot.TabIndex = 25;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.Button4_Click);
            // 
            // buttonDalej
            // 
            this.buttonDalej.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonDalej.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDalej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDalej.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDalej.Location = new System.Drawing.Point(787, 501);
            this.buttonDalej.Name = "buttonDalej";
            this.buttonDalej.Size = new System.Drawing.Size(271, 73);
            this.buttonDalej.TabIndex = 24;
            this.buttonDalej.Text = "Dalej";
            this.buttonDalej.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.textBoxNazwaPostaci);
            this.panel9.Location = new System.Drawing.Point(441, 501);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(271, 73);
            this.panel9.TabIndex = 18;
            // 
            // textBoxNazwaPostaci
            // 
            this.textBoxNazwaPostaci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNazwaPostaci.BackAlpha = 1;
            this.textBoxNazwaPostaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxNazwaPostaci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNazwaPostaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwaPostaci.Location = new System.Drawing.Point(3, 18);
            this.textBoxNazwaPostaci.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNazwaPostaci.MaxLength = 30;
            this.textBoxNazwaPostaci.Name = "textBoxNazwaPostaci";
            this.textBoxNazwaPostaci.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxNazwaPostaci.Size = new System.Drawing.Size(268, 31);
            this.textBoxNazwaPostaci.TabIndex = 31;
            this.textBoxNazwaPostaci.Text = "Nazwa postaci";
            this.textBoxNazwaPostaci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNazwaPostaci.Enter += new System.EventHandler(this.TextBoxNazwaPostaci_Enter);
            this.textBoxNazwaPostaci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNazwaPostaci_KeyDown);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.labelAtrybuty);
            this.panel8.Location = new System.Drawing.Point(441, 322);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(271, 142);
            this.panel8.TabIndex = 21;
            // 
            // labelAtrybuty
            // 
            this.labelAtrybuty.BackColor = System.Drawing.Color.Transparent;
            this.labelAtrybuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAtrybuty.Location = new System.Drawing.Point(13, 21);
            this.labelAtrybuty.Name = "labelAtrybuty";
            this.labelAtrybuty.Size = new System.Drawing.Size(247, 104);
            this.labelAtrybuty.TabIndex = 0;
            this.labelAtrybuty.Text = "Atak: 20\r\nObrona: 5\r\nHP: 200\r\nJP: 100 %";
            // 
            // pictureBoxPostacLewo
            // 
            this.pictureBoxPostacLewo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPostacLewo.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.pictureBoxPostacLewo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPostacLewo.Image = global::Anteriora.Properties.Resources.lucznikdol;
            this.pictureBoxPostacLewo.Location = new System.Drawing.Point(441, 157);
            this.pictureBoxPostacLewo.Name = "pictureBoxPostacLewo";
            this.pictureBoxPostacLewo.Size = new System.Drawing.Size(271, 148);
            this.pictureBoxPostacLewo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPostacLewo.TabIndex = 2;
            this.pictureBoxPostacLewo.TabStop = false;
            // 
            // buttonWojownik
            // 
            this.buttonWojownik.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonWojownik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWojownik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWojownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWojownik.Location = new System.Drawing.Point(98, 62);
            this.buttonWojownik.Name = "buttonWojownik";
            this.buttonWojownik.Size = new System.Drawing.Size(271, 73);
            this.buttonWojownik.TabIndex = 26;
            this.buttonWojownik.Text = "Wojownik";
            this.buttonWojownik.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(441, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 73);
            this.button1.TabIndex = 27;
            this.button1.Text = "Łucznik";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(787, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 73);
            this.button2.TabIndex = 28;
            this.button2.Text = "Mag";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Anteriora.Properties.Resources.rycerzdol;
            this.pictureBox1.Location = new System.Drawing.Point(98, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(98, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 142);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atak: 20\r\nObrona: 5\r\nHP: 200\r\nJP: 100 %";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(787, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 142);
            this.panel2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 104);
            this.label2.TabIndex = 0;
            this.label2.Text = "Atak: 20\r\nObrona: 5\r\nHP: 200\r\nJP: 100 %";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Anteriora.Properties.Resources.orkdol;
            this.pictureBox2.Location = new System.Drawing.Point(787, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.textBoxLogin);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(234, 580);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 53);
            this.panel3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.BackAlpha = 1;
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(91, 16);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLogin.MaxLength = 30;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLogin.Size = new System.Drawing.Size(245, 23);
            this.textBoxLogin.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.textBoxHaslo);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(234, 639);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 53);
            this.panel4.TabIndex = 33;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHaslo.BackAlpha = 1;
            this.textBoxHaslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxHaslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHaslo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHaslo.Location = new System.Drawing.Point(91, 16);
            this.textBoxHaslo.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxHaslo.MaxLength = 30;
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxHaslo.Size = new System.Drawing.Size(245, 23);
            this.textBoxHaslo.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasło:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WyborPostaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1213, 694);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxPostacLewo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonWojownik);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonDalej);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WyborPostaci";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.WyborPostaci_Shown);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostacLewo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private ZBobb.AlphaBlendTextBox textBoxNazwaPostaci;
        private System.Windows.Forms.Button buttonDalej;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.Label labelAtrybuty;
        private System.Windows.Forms.PictureBox pictureBoxPostacLewo;
        private System.Windows.Forms.Button buttonWojownik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private ZBobb.AlphaBlendTextBox textBoxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private ZBobb.AlphaBlendTextBox textBoxHaslo;
        private System.Windows.Forms.Label label4;
    }
}