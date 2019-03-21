namespace Anteriora
{
    partial class Koszary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Koszary));
            this.buttonWojownika = new System.Windows.Forms.Button();
            this.labelWojownikIlosc = new System.Windows.Forms.Label();
            this.labelWojownikAtak = new System.Windows.Forms.Label();
            this.labelWojownikPoziomUlepszenia = new System.Windows.Forms.Label();
            this.labelWlocznikIlosc = new System.Windows.Forms.Label();
            this.labelWlocznikPoziomUlepszenia = new System.Windows.Forms.Label();
            this.labelWlocznikAtak = new System.Windows.Forms.Label();
            this.labelPotencjalAtakuOgolnie = new System.Windows.Forms.Label();
            this.buttonWlocznik = new System.Windows.Forms.Button();
            this.buttonLucznik = new System.Windows.Forms.Button();
            this.labelLucznikPoziomUlepszenia = new System.Windows.Forms.Label();
            this.labelLucznikAtak = new System.Windows.Forms.Label();
            this.labelLucznikIlosc = new System.Windows.Forms.Label();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.timerKoszary = new System.Windows.Forms.Timer(this.components);
            this.buttonZamiana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonZwiadowca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWojownika
            // 
            this.buttonWojownika.BackColor = System.Drawing.Color.Transparent;
            this.buttonWojownika.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWojownika.BackgroundImage")));
            this.buttonWojownika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWojownika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWojownika.FlatAppearance.BorderSize = 0;
            this.buttonWojownika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWojownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWojownika.ForeColor = System.Drawing.Color.Black;
            this.buttonWojownika.Location = new System.Drawing.Point(236, 83);
            this.buttonWojownika.Name = "buttonWojownika";
            this.buttonWojownika.Size = new System.Drawing.Size(198, 73);
            this.buttonWojownika.TabIndex = 0;
            this.buttonWojownika.Text = "Werbuj wojownika (5 złota)";
            this.buttonWojownika.UseVisualStyleBackColor = false;
            this.buttonWojownika.Click += new System.EventHandler(this.buttonWojownika_Click);
            // 
            // labelWojownikIlosc
            // 
            this.labelWojownikIlosc.AutoSize = true;
            this.labelWojownikIlosc.BackColor = System.Drawing.Color.Transparent;
            this.labelWojownikIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWojownikIlosc.ForeColor = System.Drawing.Color.Black;
            this.labelWojownikIlosc.Location = new System.Drawing.Point(48, 89);
            this.labelWojownikIlosc.Name = "labelWojownikIlosc";
            this.labelWojownikIlosc.Size = new System.Drawing.Size(146, 18);
            this.labelWojownikIlosc.TabIndex = 57;
            this.labelWojownikIlosc.Text = "Ilość wojowników:";
            // 
            // labelWojownikAtak
            // 
            this.labelWojownikAtak.AutoSize = true;
            this.labelWojownikAtak.BackColor = System.Drawing.Color.Transparent;
            this.labelWojownikAtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWojownikAtak.ForeColor = System.Drawing.Color.Black;
            this.labelWojownikAtak.Location = new System.Drawing.Point(71, 109);
            this.labelWojownikAtak.Name = "labelWojownikAtak";
            this.labelWojownikAtak.Size = new System.Drawing.Size(123, 18);
            this.labelWojownikAtak.TabIndex = 58;
            this.labelWojownikAtak.Text = "Wartość ataku:";
            // 
            // labelWojownikPoziomUlepszenia
            // 
            this.labelWojownikPoziomUlepszenia.AutoSize = true;
            this.labelWojownikPoziomUlepszenia.BackColor = System.Drawing.Color.Transparent;
            this.labelWojownikPoziomUlepszenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWojownikPoziomUlepszenia.ForeColor = System.Drawing.Color.Black;
            this.labelWojownikPoziomUlepszenia.Location = new System.Drawing.Point(26, 129);
            this.labelWojownikPoziomUlepszenia.Name = "labelWojownikPoziomUlepszenia";
            this.labelWojownikPoziomUlepszenia.Size = new System.Drawing.Size(168, 18);
            this.labelWojownikPoziomUlepszenia.TabIndex = 59;
            this.labelWojownikPoziomUlepszenia.Text = "Poziom wojowników:";
            // 
            // labelWlocznikIlosc
            // 
            this.labelWlocznikIlosc.AutoSize = true;
            this.labelWlocznikIlosc.BackColor = System.Drawing.Color.Transparent;
            this.labelWlocznikIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWlocznikIlosc.ForeColor = System.Drawing.Color.Black;
            this.labelWlocznikIlosc.Location = new System.Drawing.Point(52, 249);
            this.labelWlocznikIlosc.Name = "labelWlocznikIlosc";
            this.labelWlocznikIlosc.Size = new System.Drawing.Size(142, 18);
            this.labelWlocznikIlosc.TabIndex = 60;
            this.labelWlocznikIlosc.Text = "Ilość włóczników:";
            // 
            // labelWlocznikPoziomUlepszenia
            // 
            this.labelWlocznikPoziomUlepszenia.AutoSize = true;
            this.labelWlocznikPoziomUlepszenia.BackColor = System.Drawing.Color.Transparent;
            this.labelWlocznikPoziomUlepszenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWlocznikPoziomUlepszenia.ForeColor = System.Drawing.Color.Black;
            this.labelWlocznikPoziomUlepszenia.Location = new System.Drawing.Point(30, 289);
            this.labelWlocznikPoziomUlepszenia.Name = "labelWlocznikPoziomUlepszenia";
            this.labelWlocznikPoziomUlepszenia.Size = new System.Drawing.Size(164, 18);
            this.labelWlocznikPoziomUlepszenia.TabIndex = 62;
            this.labelWlocznikPoziomUlepszenia.Text = "Poziom włóczników:";
            // 
            // labelWlocznikAtak
            // 
            this.labelWlocznikAtak.AutoSize = true;
            this.labelWlocznikAtak.BackColor = System.Drawing.Color.Transparent;
            this.labelWlocznikAtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWlocznikAtak.ForeColor = System.Drawing.Color.Black;
            this.labelWlocznikAtak.Location = new System.Drawing.Point(71, 269);
            this.labelWlocznikAtak.Name = "labelWlocznikAtak";
            this.labelWlocznikAtak.Size = new System.Drawing.Size(123, 18);
            this.labelWlocznikAtak.TabIndex = 61;
            this.labelWlocznikAtak.Text = "Wartość ataku:";
            // 
            // labelPotencjalAtakuOgolnie
            // 
            this.labelPotencjalAtakuOgolnie.AutoSize = true;
            this.labelPotencjalAtakuOgolnie.BackColor = System.Drawing.Color.Transparent;
            this.labelPotencjalAtakuOgolnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPotencjalAtakuOgolnie.ForeColor = System.Drawing.Color.Black;
            this.labelPotencjalAtakuOgolnie.Location = new System.Drawing.Point(42, 336);
            this.labelPotencjalAtakuOgolnie.Name = "labelPotencjalAtakuOgolnie";
            this.labelPotencjalAtakuOgolnie.Size = new System.Drawing.Size(222, 20);
            this.labelPotencjalAtakuOgolnie.TabIndex = 64;
            this.labelPotencjalAtakuOgolnie.Text = "Potencjał ataku jednostek:";
            // 
            // buttonWlocznik
            // 
            this.buttonWlocznik.BackColor = System.Drawing.Color.Transparent;
            this.buttonWlocznik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWlocznik.BackgroundImage")));
            this.buttonWlocznik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWlocznik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWlocznik.FlatAppearance.BorderSize = 0;
            this.buttonWlocznik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWlocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWlocznik.ForeColor = System.Drawing.Color.Black;
            this.buttonWlocznik.Location = new System.Drawing.Point(236, 239);
            this.buttonWlocznik.Name = "buttonWlocznik";
            this.buttonWlocznik.Size = new System.Drawing.Size(198, 73);
            this.buttonWlocznik.TabIndex = 65;
            this.buttonWlocznik.Text = "Werbuj włócznika (15 złota)";
            this.buttonWlocznik.UseVisualStyleBackColor = false;
            this.buttonWlocznik.Click += new System.EventHandler(this.buttonWlocznik_Click);
            // 
            // buttonLucznik
            // 
            this.buttonLucznik.BackColor = System.Drawing.Color.Transparent;
            this.buttonLucznik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLucznik.BackgroundImage")));
            this.buttonLucznik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLucznik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLucznik.FlatAppearance.BorderSize = 0;
            this.buttonLucznik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLucznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLucznik.ForeColor = System.Drawing.Color.Black;
            this.buttonLucznik.Location = new System.Drawing.Point(236, 160);
            this.buttonLucznik.Name = "buttonLucznik";
            this.buttonLucznik.Size = new System.Drawing.Size(198, 73);
            this.buttonLucznik.TabIndex = 66;
            this.buttonLucznik.Text = "Werbuj łucznika (10 złota)";
            this.buttonLucznik.UseVisualStyleBackColor = false;
            this.buttonLucznik.Click += new System.EventHandler(this.buttonLucznik_Click);
            // 
            // labelLucznikPoziomUlepszenia
            // 
            this.labelLucznikPoziomUlepszenia.AutoSize = true;
            this.labelLucznikPoziomUlepszenia.BackColor = System.Drawing.Color.Transparent;
            this.labelLucznikPoziomUlepszenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLucznikPoziomUlepszenia.ForeColor = System.Drawing.Color.Black;
            this.labelLucznikPoziomUlepszenia.Location = new System.Drawing.Point(43, 209);
            this.labelLucznikPoziomUlepszenia.Name = "labelLucznikPoziomUlepszenia";
            this.labelLucznikPoziomUlepszenia.Size = new System.Drawing.Size(151, 18);
            this.labelLucznikPoziomUlepszenia.TabIndex = 69;
            this.labelLucznikPoziomUlepszenia.Text = "Poziom łuczników:";
            // 
            // labelLucznikAtak
            // 
            this.labelLucznikAtak.AutoSize = true;
            this.labelLucznikAtak.BackColor = System.Drawing.Color.Transparent;
            this.labelLucznikAtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLucznikAtak.ForeColor = System.Drawing.Color.Black;
            this.labelLucznikAtak.Location = new System.Drawing.Point(71, 189);
            this.labelLucznikAtak.Name = "labelLucznikAtak";
            this.labelLucznikAtak.Size = new System.Drawing.Size(123, 18);
            this.labelLucznikAtak.TabIndex = 68;
            this.labelLucznikAtak.Text = "Wartość ataku:";
            // 
            // labelLucznikIlosc
            // 
            this.labelLucznikIlosc.AutoSize = true;
            this.labelLucznikIlosc.BackColor = System.Drawing.Color.Transparent;
            this.labelLucznikIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLucznikIlosc.ForeColor = System.Drawing.Color.Black;
            this.labelLucznikIlosc.Location = new System.Drawing.Point(65, 169);
            this.labelLucznikIlosc.Name = "labelLucznikIlosc";
            this.labelLucznikIlosc.Size = new System.Drawing.Size(129, 18);
            this.labelLucznikIlosc.TabIndex = 67;
            this.labelLucznikIlosc.Text = "Ilość łuczników:";
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAnuluj.BackgroundImage")));
            this.buttonAnuluj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnuluj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnuluj.FlatAppearance.BorderSize = 0;
            this.buttonAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAnuluj.ForeColor = System.Drawing.Color.Black;
            this.buttonAnuluj.Location = new System.Drawing.Point(421, 322);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(123, 49);
            this.buttonAnuluj.TabIndex = 74;
            this.buttonAnuluj.Text = "Powrót";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // timerKoszary
            // 
            this.timerKoszary.Tick += new System.EventHandler(this.timerKoszary_Tick);
            // 
            // buttonZamiana
            // 
            this.buttonZamiana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZamiana.BackgroundImage")));
            this.buttonZamiana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZamiana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZamiana.FlatAppearance.BorderSize = 0;
            this.buttonZamiana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamiana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZamiana.ForeColor = System.Drawing.Color.Black;
            this.buttonZamiana.Location = new System.Drawing.Point(421, 25);
            this.buttonZamiana.Name = "buttonZamiana";
            this.buttonZamiana.Size = new System.Drawing.Size(123, 49);
            this.buttonZamiana.TabIndex = 75;
            this.buttonZamiana.Text = "Jednostki defensywne";
            this.buttonZamiana.UseVisualStyleBackColor = true;
            this.buttonZamiana.Click += new System.EventHandler(this.buttonZamiana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 76;
            this.label1.Text = "Jednostki ofensywne";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(449, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 73);
            this.button1.TabIndex = 77;
            this.button1.Text = "Ulepsz wojowników";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(449, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 73);
            this.button2.TabIndex = 78;
            this.button2.Text = "Ulepsz łuczników";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(449, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 73);
            this.button3.TabIndex = 79;
            this.button3.Text = "Ulepsz włóczników";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonZwiadowca
            // 
            this.buttonZwiadowca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZwiadowca.BackgroundImage")));
            this.buttonZwiadowca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZwiadowca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZwiadowca.FlatAppearance.BorderSize = 0;
            this.buttonZwiadowca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZwiadowca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZwiadowca.ForeColor = System.Drawing.Color.Black;
            this.buttonZwiadowca.Location = new System.Drawing.Point(292, 25);
            this.buttonZwiadowca.Name = "buttonZwiadowca";
            this.buttonZwiadowca.Size = new System.Drawing.Size(123, 49);
            this.buttonZwiadowca.TabIndex = 80;
            this.buttonZwiadowca.Text = "Jednostki zwiadowcze";
            this.buttonZwiadowca.UseVisualStyleBackColor = true;
            this.buttonZwiadowca.Click += new System.EventHandler(this.buttonZwiadowca_Click);
            // 
            // Koszary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonAnuluj;
            this.ClientSize = new System.Drawing.Size(561, 393);
            this.Controls.Add(this.buttonZwiadowca);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZamiana);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.labelLucznikPoziomUlepszenia);
            this.Controls.Add(this.labelLucznikAtak);
            this.Controls.Add(this.labelLucznikIlosc);
            this.Controls.Add(this.buttonLucznik);
            this.Controls.Add(this.buttonWlocznik);
            this.Controls.Add(this.labelPotencjalAtakuOgolnie);
            this.Controls.Add(this.labelWlocznikPoziomUlepszenia);
            this.Controls.Add(this.labelWlocznikAtak);
            this.Controls.Add(this.labelWlocznikIlosc);
            this.Controls.Add(this.labelWojownikPoziomUlepszenia);
            this.Controls.Add(this.labelWojownikAtak);
            this.Controls.Add(this.labelWojownikIlosc);
            this.Controls.Add(this.buttonWojownika);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Koszary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koszary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWojownika;
        public System.Windows.Forms.Label labelWojownikIlosc;
        public System.Windows.Forms.Label labelWojownikAtak;
        public System.Windows.Forms.Label labelWojownikPoziomUlepszenia;
        public System.Windows.Forms.Label labelWlocznikIlosc;
        public System.Windows.Forms.Label labelWlocznikPoziomUlepszenia;
        public System.Windows.Forms.Label labelWlocznikAtak;
        public System.Windows.Forms.Label labelPotencjalAtakuOgolnie;
        private System.Windows.Forms.Button buttonWlocznik;
        private System.Windows.Forms.Button buttonLucznik;
        public System.Windows.Forms.Label labelLucznikPoziomUlepszenia;
        public System.Windows.Forms.Label labelLucznikAtak;
        public System.Windows.Forms.Label labelLucznikIlosc;
        private System.Windows.Forms.Button buttonAnuluj;
        public System.Windows.Forms.Timer timerKoszary;
        private System.Windows.Forms.Button buttonZamiana;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonZwiadowca;
    }
}