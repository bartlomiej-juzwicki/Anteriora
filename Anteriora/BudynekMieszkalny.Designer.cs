namespace Anteriora
{
    partial class BudynekMieszkalny
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
            this.buttonOtwarty = new System.Windows.Forms.Button();
            this.buttonZamkniety = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSpelnijZyczenia = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxListaZyczen = new System.Windows.Forms.TextBox();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.timerBudynekMieszkalny = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPoziomZadowolenia = new System.Windows.Forms.Label();
            this.labelLiczbaBezrobotynchMieszkancow = new System.Windows.Forms.Label();
            this.labelLiczbaPracujacychMieszkancow = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelLiczbaMiejscBudynku = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelLiczbaMieszkancow = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBoxStrzalka1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStrzalka2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStrzalka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStrzalka2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOtwarty
            // 
            this.buttonOtwarty.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonOtwarty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOtwarty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOtwarty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOtwarty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonOtwarty.Location = new System.Drawing.Point(466, 30);
            this.buttonOtwarty.Name = "buttonOtwarty";
            this.buttonOtwarty.Size = new System.Drawing.Size(211, 80);
            this.buttonOtwarty.TabIndex = 0;
            this.buttonOtwarty.Text = "Otwarty";
            this.buttonOtwarty.UseVisualStyleBackColor = true;
            this.buttonOtwarty.Click += new System.EventHandler(this.buttonOtwarty_Click);
            // 
            // buttonZamkniety
            // 
            this.buttonZamkniety.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonZamkniety.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZamkniety.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZamkniety.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamkniety.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonZamkniety.Location = new System.Drawing.Point(466, 125);
            this.buttonZamkniety.Name = "buttonZamkniety";
            this.buttonZamkniety.Size = new System.Drawing.Size(211, 80);
            this.buttonZamkniety.TabIndex = 1;
            this.buttonZamkniety.Text = "Zamknięty";
            this.buttonZamkniety.UseVisualStyleBackColor = true;
            this.buttonZamkniety.Click += new System.EventHandler(this.buttonZamkniety_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista życzeń mieszkańców:";
            // 
            // buttonSpelnijZyczenia
            // 
            this.buttonSpelnijZyczenia.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonSpelnijZyczenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpelnijZyczenia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpelnijZyczenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpelnijZyczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSpelnijZyczenia.Location = new System.Drawing.Point(466, 220);
            this.buttonSpelnijZyczenia.Name = "buttonSpelnijZyczenia";
            this.buttonSpelnijZyczenia.Size = new System.Drawing.Size(211, 80);
            this.buttonSpelnijZyczenia.TabIndex = 7;
            this.buttonSpelnijZyczenia.Text = "Spełnij życzenia mieszkańców";
            this.buttonSpelnijZyczenia.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxListaZyczen, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 239);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(409, 157);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // textBoxListaZyczen
            // 
            this.textBoxListaZyczen.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxListaZyczen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxListaZyczen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxListaZyczen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxListaZyczen.HideSelection = false;
            this.textBoxListaZyczen.Location = new System.Drawing.Point(3, 3);
            this.textBoxListaZyczen.Multiline = true;
            this.textBoxListaZyczen.Name = "textBoxListaZyczen";
            this.textBoxListaZyczen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxListaZyczen.ShortcutsEnabled = false;
            this.textBoxListaZyczen.Size = new System.Drawing.Size(403, 151);
            this.textBoxListaZyczen.TabIndex = 1;
            this.textBoxListaZyczen.TabStop = false;
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonPowrot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPowrot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPowrot.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPowrot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPowrot.Location = new System.Drawing.Point(466, 316);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(211, 80);
            this.buttonPowrot.TabIndex = 9;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // timerBudynekMieszkalny
            // 
            this.timerBudynekMieszkalny.Tick += new System.EventHandler(this.timerBudynekMieszkalny_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.BurlyWood;
            this.tableLayoutPanel2.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelPoziomZadowolenia, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelLiczbaBezrobotynchMieszkancow, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelLiczbaPracujacychMieszkancow, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelLiczbaMiejscBudynku, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelLiczbaMieszkancow, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(34, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(406, 186);
            this.tableLayoutPanel2.TabIndex = 56;
            // 
            // labelPoziomZadowolenia
            // 
            this.labelPoziomZadowolenia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoziomZadowolenia.AutoSize = true;
            this.labelPoziomZadowolenia.BackColor = System.Drawing.Color.Transparent;
            this.labelPoziomZadowolenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoziomZadowolenia.Location = new System.Drawing.Point(296, 160);
            this.labelPoziomZadowolenia.Name = "labelPoziomZadowolenia";
            this.labelPoziomZadowolenia.Size = new System.Drawing.Size(107, 15);
            this.labelPoziomZadowolenia.TabIndex = 29;
            this.labelPoziomZadowolenia.Text = "0";
            this.labelPoziomZadowolenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLiczbaBezrobotynchMieszkancow
            // 
            this.labelLiczbaBezrobotynchMieszkancow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLiczbaBezrobotynchMieszkancow.AutoSize = true;
            this.labelLiczbaBezrobotynchMieszkancow.BackColor = System.Drawing.Color.Transparent;
            this.labelLiczbaBezrobotynchMieszkancow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLiczbaBezrobotynchMieszkancow.Location = new System.Drawing.Point(296, 119);
            this.labelLiczbaBezrobotynchMieszkancow.Name = "labelLiczbaBezrobotynchMieszkancow";
            this.labelLiczbaBezrobotynchMieszkancow.Size = new System.Drawing.Size(107, 15);
            this.labelLiczbaBezrobotynchMieszkancow.TabIndex = 23;
            this.labelLiczbaBezrobotynchMieszkancow.Text = "0";
            this.labelLiczbaBezrobotynchMieszkancow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLiczbaPracujacychMieszkancow
            // 
            this.labelLiczbaPracujacychMieszkancow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLiczbaPracujacychMieszkancow.AutoSize = true;
            this.labelLiczbaPracujacychMieszkancow.BackColor = System.Drawing.Color.Transparent;
            this.labelLiczbaPracujacychMieszkancow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLiczbaPracujacychMieszkancow.Location = new System.Drawing.Point(296, 75);
            this.labelLiczbaPracujacychMieszkancow.Name = "labelLiczbaPracujacychMieszkancow";
            this.labelLiczbaPracujacychMieszkancow.Size = new System.Drawing.Size(107, 15);
            this.labelLiczbaPracujacychMieszkancow.TabIndex = 17;
            this.labelLiczbaPracujacychMieszkancow.Text = "0";
            this.labelLiczbaPracujacychMieszkancow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Liczba mieszkańców";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLiczbaMiejscBudynku
            // 
            this.labelLiczbaMiejscBudynku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLiczbaMiejscBudynku.AutoSize = true;
            this.labelLiczbaMiejscBudynku.BackColor = System.Drawing.Color.Transparent;
            this.labelLiczbaMiejscBudynku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLiczbaMiejscBudynku.Location = new System.Drawing.Point(296, 7);
            this.labelLiczbaMiejscBudynku.Name = "labelLiczbaMiejscBudynku";
            this.labelLiczbaMiejscBudynku.Size = new System.Drawing.Size(107, 15);
            this.labelLiczbaMiejscBudynku.TabIndex = 5;
            this.labelLiczbaMiejscBudynku.Text = "100";
            this.labelLiczbaMiejscBudynku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(3, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(287, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Liczba pracujących mieszkańców";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLiczbaMieszkancow
            // 
            this.labelLiczbaMieszkancow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLiczbaMieszkancow.AutoSize = true;
            this.labelLiczbaMieszkancow.BackColor = System.Drawing.Color.Transparent;
            this.labelLiczbaMieszkancow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLiczbaMieszkancow.Location = new System.Drawing.Point(296, 37);
            this.labelLiczbaMieszkancow.Name = "labelLiczbaMieszkancow";
            this.labelLiczbaMieszkancow.Size = new System.Drawing.Size(107, 15);
            this.labelLiczbaMieszkancow.TabIndex = 11;
            this.labelLiczbaMieszkancow.Text = "0";
            this.labelLiczbaMieszkancow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(3, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(287, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Poziom zadowolenia";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(3, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(287, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Liczba bezrobotnych mieszkańców";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(287, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Liczba miejsc w budynku";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxStrzalka1
            // 
            this.pictureBoxStrzalka1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStrzalka1.BackgroundImage = global::Anteriora.Properties.Resources.strzalka;
            this.pictureBoxStrzalka1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStrzalka1.Location = new System.Drawing.Point(632, 51);
            this.pictureBoxStrzalka1.Name = "pictureBoxStrzalka1";
            this.pictureBoxStrzalka1.Size = new System.Drawing.Size(27, 36);
            this.pictureBoxStrzalka1.TabIndex = 57;
            this.pictureBoxStrzalka1.TabStop = false;
            this.pictureBoxStrzalka1.Visible = false;
            // 
            // pictureBoxStrzalka2
            // 
            this.pictureBoxStrzalka2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStrzalka2.BackgroundImage = global::Anteriora.Properties.Resources.strzalka;
            this.pictureBoxStrzalka2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStrzalka2.Location = new System.Drawing.Point(486, 51);
            this.pictureBoxStrzalka2.Name = "pictureBoxStrzalka2";
            this.pictureBoxStrzalka2.Size = new System.Drawing.Size(27, 36);
            this.pictureBoxStrzalka2.TabIndex = 58;
            this.pictureBoxStrzalka2.TabStop = false;
            this.pictureBoxStrzalka2.Visible = false;
            // 
            // BudynekMieszkalny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonPowrot;
            this.ClientSize = new System.Drawing.Size(708, 427);
            this.Controls.Add(this.pictureBoxStrzalka2);
            this.Controls.Add(this.pictureBoxStrzalka1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonSpelnijZyczenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZamkniety);
            this.Controls.Add(this.buttonOtwarty);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BudynekMieszkalny";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudynekMieszkalny";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStrzalka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStrzalka2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtwarty;
        private System.Windows.Forms.Button buttonZamkniety;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSpelnijZyczenia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxListaZyczen;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.Timer timerBudynekMieszkalny;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelPoziomZadowolenia;
        private System.Windows.Forms.Label labelLiczbaBezrobotynchMieszkancow;
        private System.Windows.Forms.Label labelLiczbaPracujacychMieszkancow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelLiczbaMiejscBudynku;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelLiczbaMieszkancow;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.PictureBox pictureBoxStrzalka1;
        public System.Windows.Forms.PictureBox pictureBoxStrzalka2;
    }
}