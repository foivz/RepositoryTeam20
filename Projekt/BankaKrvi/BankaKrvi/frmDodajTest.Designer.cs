namespace BankaKrvi
{
    partial class frmDodajTest
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
            this.lblDntOdobren = new System.Windows.Forms.Label();
            this.lblDntVrijeme = new System.Windows.Forms.Label();
            this.lblDntUstanova = new System.Windows.Forms.Label();
            this.lblDntBolest = new System.Windows.Forms.Label();
            this.lblDntDonacija = new System.Windows.Forms.Label();
            this.dtpDntVrijeme = new System.Windows.Forms.DateTimePicker();
            this.cboxDntUstanova = new System.Windows.Forms.ComboBox();
            this.cboxDntBolest = new System.Windows.Forms.ComboBox();
            this.cboxDntDonacija = new System.Windows.Forms.ComboBox();
            this.btnDntDodaj = new System.Windows.Forms.Button();
            this.cboxDntOdobren = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDntOdobren
            // 
            this.lblDntOdobren.AutoSize = true;
            this.lblDntOdobren.Location = new System.Drawing.Point(138, 77);
            this.lblDntOdobren.Name = "lblDntOdobren";
            this.lblDntOdobren.Size = new System.Drawing.Size(48, 13);
            this.lblDntOdobren.TabIndex = 2;
            this.lblDntOdobren.Text = "Odobren";
            // 
            // lblDntVrijeme
            // 
            this.lblDntVrijeme.AutoSize = true;
            this.lblDntVrijeme.Location = new System.Drawing.Point(145, 115);
            this.lblDntVrijeme.Name = "lblDntVrijeme";
            this.lblDntVrijeme.Size = new System.Drawing.Size(41, 13);
            this.lblDntVrijeme.TabIndex = 3;
            this.lblDntVrijeme.Text = "Vrijeme";
            // 
            // lblDntUstanova
            // 
            this.lblDntUstanova.AutoSize = true;
            this.lblDntUstanova.Location = new System.Drawing.Point(133, 153);
            this.lblDntUstanova.Name = "lblDntUstanova";
            this.lblDntUstanova.Size = new System.Drawing.Size(53, 13);
            this.lblDntUstanova.TabIndex = 4;
            this.lblDntUstanova.Text = "Ustanova";
            // 
            // lblDntBolest
            // 
            this.lblDntBolest.AutoSize = true;
            this.lblDntBolest.Location = new System.Drawing.Point(150, 191);
            this.lblDntBolest.Name = "lblDntBolest";
            this.lblDntBolest.Size = new System.Drawing.Size(36, 13);
            this.lblDntBolest.TabIndex = 5;
            this.lblDntBolest.Text = "Bolest";
            // 
            // lblDntDonacija
            // 
            this.lblDntDonacija.AutoSize = true;
            this.lblDntDonacija.Location = new System.Drawing.Point(137, 229);
            this.lblDntDonacija.Name = "lblDntDonacija";
            this.lblDntDonacija.Size = new System.Drawing.Size(49, 13);
            this.lblDntDonacija.TabIndex = 6;
            this.lblDntDonacija.Text = "Donacija";
            // 
            // dtpDntVrijeme
            // 
            this.dtpDntVrijeme.Location = new System.Drawing.Point(210, 113);
            this.dtpDntVrijeme.Name = "dtpDntVrijeme";
            this.dtpDntVrijeme.Size = new System.Drawing.Size(225, 20);
            this.dtpDntVrijeme.TabIndex = 8;
            // 
            // cboxDntUstanova
            // 
            this.cboxDntUstanova.FormattingEnabled = true;
            this.cboxDntUstanova.Location = new System.Drawing.Point(210, 151);
            this.cboxDntUstanova.Name = "cboxDntUstanova";
            this.cboxDntUstanova.Size = new System.Drawing.Size(225, 21);
            this.cboxDntUstanova.TabIndex = 9;
            // 
            // cboxDntBolest
            // 
            this.cboxDntBolest.FormattingEnabled = true;
            this.cboxDntBolest.Location = new System.Drawing.Point(210, 190);
            this.cboxDntBolest.Name = "cboxDntBolest";
            this.cboxDntBolest.Size = new System.Drawing.Size(225, 21);
            this.cboxDntBolest.TabIndex = 10;
            // 
            // cboxDntDonacija
            // 
            this.cboxDntDonacija.FormattingEnabled = true;
            this.cboxDntDonacija.Location = new System.Drawing.Point(210, 229);
            this.cboxDntDonacija.Name = "cboxDntDonacija";
            this.cboxDntDonacija.Size = new System.Drawing.Size(225, 21);
            this.cboxDntDonacija.TabIndex = 11;
            // 
            // btnDntDodaj
            // 
            this.btnDntDodaj.Location = new System.Drawing.Point(210, 297);
            this.btnDntDodaj.Name = "btnDntDodaj";
            this.btnDntDodaj.Size = new System.Drawing.Size(225, 23);
            this.btnDntDodaj.TabIndex = 12;
            this.btnDntDodaj.Text = "Dodaj Test";
            this.btnDntDodaj.UseVisualStyleBackColor = true;
            this.btnDntDodaj.Click += new System.EventHandler(this.btnDntDodaj_Click);
            // 
            // cboxDntOdobren
            // 
            this.cboxDntOdobren.FormattingEnabled = true;
            this.cboxDntOdobren.Items.AddRange(new object[] {
            "DA",
            "NE"});
            this.cboxDntOdobren.Location = new System.Drawing.Point(210, 74);
            this.cboxDntOdobren.Name = "cboxDntOdobren";
            this.cboxDntOdobren.Size = new System.Drawing.Size(225, 21);
            this.cboxDntOdobren.TabIndex = 7;
            // 
            // frmDodajTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnDntDodaj);
            this.Controls.Add(this.cboxDntDonacija);
            this.Controls.Add(this.cboxDntBolest);
            this.Controls.Add(this.cboxDntUstanova);
            this.Controls.Add(this.dtpDntVrijeme);
            this.Controls.Add(this.cboxDntOdobren);
            this.Controls.Add(this.lblDntDonacija);
            this.Controls.Add(this.lblDntBolest);
            this.Controls.Add(this.lblDntUstanova);
            this.Controls.Add(this.lblDntVrijeme);
            this.Controls.Add(this.lblDntOdobren);
            this.Name = "frmDodajTest";
            this.Text = "Dodaj test";
            this.Load += new System.EventHandler(this.frmDodajTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDntOdobren;
        private System.Windows.Forms.Label lblDntVrijeme;
        private System.Windows.Forms.Label lblDntUstanova;
        private System.Windows.Forms.Label lblDntBolest;
        private System.Windows.Forms.Label lblDntDonacija;
        private System.Windows.Forms.DateTimePicker dtpDntVrijeme;
        private System.Windows.Forms.ComboBox cboxDntUstanova;
        private System.Windows.Forms.ComboBox cboxDntBolest;
        private System.Windows.Forms.ComboBox cboxDntDonacija;
        private System.Windows.Forms.Button btnDntDodaj;
        private System.Windows.Forms.ComboBox cboxDntOdobren;
    }
}