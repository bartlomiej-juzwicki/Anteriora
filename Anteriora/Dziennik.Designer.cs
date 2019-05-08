namespace Anteriora
{
    partial class Dziennik
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
            this.textBoxDziennik = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonZamknijDziennik = new System.Windows.Forms.Button();
            this.buttonAktualizacja = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDziennik
            // 
            this.textBoxDziennik.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxDziennik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDziennik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDziennik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDziennik.HideSelection = false;
            this.textBoxDziennik.Location = new System.Drawing.Point(3, 3);
            this.textBoxDziennik.Multiline = true;
            this.textBoxDziennik.Name = "textBoxDziennik";
            this.textBoxDziennik.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDziennik.ShortcutsEnabled = false;
            this.textBoxDziennik.Size = new System.Drawing.Size(386, 350);
            this.textBoxDziennik.TabIndex = 0;
            this.textBoxDziennik.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDziennik, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 364);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonZamknijDziennik
            // 
            this.buttonZamknijDziennik.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonZamknijDziennik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZamknijDziennik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZamknijDziennik.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonZamknijDziennik.FlatAppearance.BorderSize = 0;
            this.buttonZamknijDziennik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamknijDziennik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZamknijDziennik.Location = new System.Drawing.Point(204, 380);
            this.buttonZamknijDziennik.Name = "buttonZamknijDziennik";
            this.buttonZamknijDziennik.Size = new System.Drawing.Size(185, 48);
            this.buttonZamknijDziennik.TabIndex = 2;
            this.buttonZamknijDziennik.Text = "Zamknij dziennik";
            this.buttonZamknijDziennik.UseVisualStyleBackColor = true;
            this.buttonZamknijDziennik.Click += new System.EventHandler(this.buttonZamknijDziennik_Click);
            // 
            // buttonAktualizacja
            // 
            this.buttonAktualizacja.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.buttonAktualizacja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAktualizacja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAktualizacja.FlatAppearance.BorderSize = 0;
            this.buttonAktualizacja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAktualizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktualizacja.Location = new System.Drawing.Point(12, 380);
            this.buttonAktualizacja.Name = "buttonAktualizacja";
            this.buttonAktualizacja.Size = new System.Drawing.Size(186, 48);
            this.buttonAktualizacja.TabIndex = 3;
            this.buttonAktualizacja.Text = "Aktualizuj dziennik";
            this.buttonAktualizacja.UseVisualStyleBackColor = true;
            this.buttonAktualizacja.Click += new System.EventHandler(this.buttonAktualizacja_Click);
            // 
            // Dziennik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonZamknijDziennik;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.buttonAktualizacja);
            this.Controls.Add(this.buttonZamknijDziennik);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1475, 235);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dziennik";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dziennik";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDziennik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonZamknijDziennik;
        private System.Windows.Forms.Button buttonAktualizacja;
    }
}