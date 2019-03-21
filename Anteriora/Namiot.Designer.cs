namespace Anteriora
{
    partial class Namiot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Namiot));
            this.buttonBudowaNamiot = new System.Windows.Forms.Button();
            this.buttonZapiszStanGryNamiot = new System.Windows.Forms.Button();
            this.buttonWyjscieNamiot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBudowaNamiot
            // 
            this.buttonBudowaNamiot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBudowaNamiot.BackgroundImage")));
            this.buttonBudowaNamiot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBudowaNamiot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBudowaNamiot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBudowaNamiot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonBudowaNamiot.Location = new System.Drawing.Point(12, 12);
            this.buttonBudowaNamiot.Name = "buttonBudowaNamiot";
            this.buttonBudowaNamiot.Size = new System.Drawing.Size(304, 75);
            this.buttonBudowaNamiot.TabIndex = 0;
            this.buttonBudowaNamiot.Text = "Budowa";
            this.buttonBudowaNamiot.UseVisualStyleBackColor = true;
            this.buttonBudowaNamiot.Click += new System.EventHandler(this.buttonBudowaNamiot_Click);
            // 
            // buttonZapiszStanGryNamiot
            // 
            this.buttonZapiszStanGryNamiot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZapiszStanGryNamiot.BackgroundImage")));
            this.buttonZapiszStanGryNamiot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonZapiszStanGryNamiot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZapiszStanGryNamiot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZapiszStanGryNamiot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonZapiszStanGryNamiot.Location = new System.Drawing.Point(12, 93);
            this.buttonZapiszStanGryNamiot.Name = "buttonZapiszStanGryNamiot";
            this.buttonZapiszStanGryNamiot.Size = new System.Drawing.Size(304, 75);
            this.buttonZapiszStanGryNamiot.TabIndex = 1;
            this.buttonZapiszStanGryNamiot.Text = "Zapis stanu gry";
            this.buttonZapiszStanGryNamiot.UseVisualStyleBackColor = true;
            // 
            // buttonWyjscieNamiot
            // 
            this.buttonWyjscieNamiot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWyjscieNamiot.BackgroundImage")));
            this.buttonWyjscieNamiot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWyjscieNamiot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWyjscieNamiot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyjscieNamiot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonWyjscieNamiot.Location = new System.Drawing.Point(12, 174);
            this.buttonWyjscieNamiot.Name = "buttonWyjscieNamiot";
            this.buttonWyjscieNamiot.Size = new System.Drawing.Size(304, 75);
            this.buttonWyjscieNamiot.TabIndex = 2;
            this.buttonWyjscieNamiot.Text = "Wyjście z namiotu";
            this.buttonWyjscieNamiot.UseVisualStyleBackColor = true;
            this.buttonWyjscieNamiot.Click += new System.EventHandler(this.buttonWyjscieNamiot_Click);
            // 
            // Namiot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Anteriora.Properties.Resources.pasekzyciatlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonWyjscieNamiot;
            this.ClientSize = new System.Drawing.Size(328, 262);
            this.Controls.Add(this.buttonWyjscieNamiot);
            this.Controls.Add(this.buttonZapiszStanGryNamiot);
            this.Controls.Add(this.buttonBudowaNamiot);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Namiot";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Namiot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBudowaNamiot;
        private System.Windows.Forms.Button buttonZapiszStanGryNamiot;
        private System.Windows.Forms.Button buttonWyjscieNamiot;
    }
}