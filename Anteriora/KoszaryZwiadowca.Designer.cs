namespace Anteriora
{
    partial class KoszaryZwiadowca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KoszaryZwiadowca));
            this.buttonUlepszZwiadowca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZwiadowca = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.labelZwiadowcaPoziomUlepszenia = new System.Windows.Forms.Label();
            this.labelZwiadowcaAtak = new System.Windows.Forms.Label();
            this.labelZwiadowcaIlosc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonZapisDoDziennika = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNotatkaZwiadowcy = new System.Windows.Forms.TextBox();
            this.buttonDziennik = new System.Windows.Forms.Button();
            this.timerZwiadowcaTekst = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUlepszZwiadowca
            // 
            this.buttonUlepszZwiadowca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUlepszZwiadowca.BackgroundImage")));
            this.buttonUlepszZwiadowca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUlepszZwiadowca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUlepszZwiadowca.FlatAppearance.BorderSize = 0;
            this.buttonUlepszZwiadowca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUlepszZwiadowca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUlepszZwiadowca.Location = new System.Drawing.Point(449, 83);
            this.buttonUlepszZwiadowca.Name = "buttonUlepszZwiadowca";
            this.buttonUlepszZwiadowca.Size = new System.Drawing.Size(95, 73);
            this.buttonUlepszZwiadowca.TabIndex = 103;
            this.buttonUlepszZwiadowca.Text = "Ulepsz zwiadowców";
            this.buttonUlepszZwiadowca.UseVisualStyleBackColor = true;
            this.buttonUlepszZwiadowca.Click += new System.EventHandler(this.buttonUlepszZwiadowca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 102;
            this.label1.Text = "Jednostki zwiadowcze";
            // 
            // buttonZwiadowca
            // 
            this.buttonZwiadowca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZwiadowca.BackgroundImage")));
            this.buttonZwiadowca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZwiadowca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZwiadowca.FlatAppearance.BorderSize = 0;
            this.buttonZwiadowca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonZwiadowca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZwiadowca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZwiadowca.Location = new System.Drawing.Point(236, 83);
            this.buttonZwiadowca.Name = "buttonZwiadowca";
            this.buttonZwiadowca.Size = new System.Drawing.Size(198, 73);
            this.buttonZwiadowca.TabIndex = 100;
            this.buttonZwiadowca.Text = "Werbuj zwiadowce (5 złota)";
            this.buttonZwiadowca.UseVisualStyleBackColor = true;
            this.buttonZwiadowca.Click += new System.EventHandler(this.buttonZwiadowca_Click);
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
            this.buttonAnuluj.Location = new System.Drawing.Point(421, 322);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(123, 49);
            this.buttonAnuluj.TabIndex = 105;
            this.buttonAnuluj.Text = "Powrót";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // labelZwiadowcaPoziomUlepszenia
            // 
            this.labelZwiadowcaPoziomUlepszenia.AutoSize = true;
            this.labelZwiadowcaPoziomUlepszenia.BackColor = System.Drawing.Color.Transparent;
            this.labelZwiadowcaPoziomUlepszenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZwiadowcaPoziomUlepszenia.ForeColor = System.Drawing.Color.Black;
            this.labelZwiadowcaPoziomUlepszenia.Location = new System.Drawing.Point(26, 129);
            this.labelZwiadowcaPoziomUlepszenia.Name = "labelZwiadowcaPoziomUlepszenia";
            this.labelZwiadowcaPoziomUlepszenia.Size = new System.Drawing.Size(186, 18);
            this.labelZwiadowcaPoziomUlepszenia.TabIndex = 108;
            this.labelZwiadowcaPoziomUlepszenia.Text = "Poziom zwiadowców: 1";
            // 
            // labelZwiadowcaAtak
            // 
            this.labelZwiadowcaAtak.AutoSize = true;
            this.labelZwiadowcaAtak.BackColor = System.Drawing.Color.Transparent;
            this.labelZwiadowcaAtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZwiadowcaAtak.ForeColor = System.Drawing.Color.Black;
            this.labelZwiadowcaAtak.Location = new System.Drawing.Point(12, 109);
            this.labelZwiadowcaAtak.Name = "labelZwiadowcaAtak";
            this.labelZwiadowcaAtak.Size = new System.Drawing.Size(215, 18);
            this.labelZwiadowcaAtak.TabIndex = 107;
            this.labelZwiadowcaAtak.Text = "Szansa na powodzenie: 5%\r\n";
            // 
            // labelZwiadowcaIlosc
            // 
            this.labelZwiadowcaIlosc.AutoSize = true;
            this.labelZwiadowcaIlosc.BackColor = System.Drawing.Color.Transparent;
            this.labelZwiadowcaIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZwiadowcaIlosc.ForeColor = System.Drawing.Color.Black;
            this.labelZwiadowcaIlosc.Location = new System.Drawing.Point(48, 89);
            this.labelZwiadowcaIlosc.Name = "labelZwiadowcaIlosc";
            this.labelZwiadowcaIlosc.Size = new System.Drawing.Size(164, 18);
            this.labelZwiadowcaIlosc.TabIndex = 106;
            this.labelZwiadowcaIlosc.Text = "Ilość zwiadowców: 1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonZapisDoDziennika, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 205);
            this.tableLayoutPanel1.TabIndex = 109;
            // 
            // buttonZapisDoDziennika
            // 
            this.buttonZapisDoDziennika.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZapisDoDziennika.BackgroundImage")));
            this.buttonZapisDoDziennika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZapisDoDziennika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZapisDoDziennika.FlatAppearance.BorderSize = 0;
            this.buttonZapisDoDziennika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZapisDoDziennika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapisDoDziennika.Location = new System.Drawing.Point(3, 163);
            this.buttonZapisDoDziennika.Name = "buttonZapisDoDziennika";
            this.buttonZapisDoDziennika.Size = new System.Drawing.Size(380, 39);
            this.buttonZapisDoDziennika.TabIndex = 110;
            this.buttonZapisDoDziennika.Text = "Zapis do dziennika";
            this.buttonZapisDoDziennika.UseVisualStyleBackColor = true;
            this.buttonZapisDoDziennika.Click += new System.EventHandler(this.buttonZapisDoDziennika_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel2.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxNotatkaZwiadowcy, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 154);
            this.tableLayoutPanel2.TabIndex = 111;
            // 
            // textBoxNotatkaZwiadowcy
            // 
            this.textBoxNotatkaZwiadowcy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxNotatkaZwiadowcy.BackColor = System.Drawing.Color.Tan;
            this.textBoxNotatkaZwiadowcy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNotatkaZwiadowcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNotatkaZwiadowcy.Location = new System.Drawing.Point(3, 3);
            this.textBoxNotatkaZwiadowcy.Multiline = true;
            this.textBoxNotatkaZwiadowcy.Name = "textBoxNotatkaZwiadowcy";
            this.textBoxNotatkaZwiadowcy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotatkaZwiadowcy.Size = new System.Drawing.Size(372, 148);
            this.textBoxNotatkaZwiadowcy.TabIndex = 0;
            // 
            // buttonDziennik
            // 
            this.buttonDziennik.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonDziennik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDziennik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDziennik.FlatAppearance.BorderSize = 0;
            this.buttonDziennik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDziennik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDziennik.Location = new System.Drawing.Point(442, 185);
            this.buttonDziennik.Name = "buttonDziennik";
            this.buttonDziennik.Size = new System.Drawing.Size(87, 105);
            this.buttonDziennik.TabIndex = 110;
            this.buttonDziennik.Text = "Dziennik";
            this.buttonDziennik.UseVisualStyleBackColor = true;
            this.buttonDziennik.Click += new System.EventHandler(this.buttonDziennik_Click);
            // 
            // timerZwiadowcaTekst
            // 
            this.timerZwiadowcaTekst.Interval = 1000;
            this.timerZwiadowcaTekst.Tick += new System.EventHandler(this.timerZwiadowcaTekst_Tick);
            // 
            // KoszaryZwiadowca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonAnuluj;
            this.ClientSize = new System.Drawing.Size(561, 393);
            this.Controls.Add(this.buttonDziennik);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelZwiadowcaPoziomUlepszenia);
            this.Controls.Add(this.labelZwiadowcaAtak);
            this.Controls.Add(this.labelZwiadowcaIlosc);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonUlepszZwiadowca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZwiadowca);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KoszaryZwiadowca";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KoszaryZwiadowca";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUlepszZwiadowca;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZwiadowca;
        private System.Windows.Forms.Button buttonAnuluj;
        public System.Windows.Forms.Label labelZwiadowcaPoziomUlepszenia;
        public System.Windows.Forms.Label labelZwiadowcaAtak;
        public System.Windows.Forms.Label labelZwiadowcaIlosc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonZapisDoDziennika;
        private System.Windows.Forms.TextBox textBoxNotatkaZwiadowcy;
        private System.Windows.Forms.Button buttonDziennik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timerZwiadowcaTekst;
    }
}