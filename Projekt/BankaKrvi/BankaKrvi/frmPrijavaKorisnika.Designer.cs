namespace BankaKrvi
{
    partial class frmPrijavaKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijavaKorisnika));
            this.txtPrkKorIme = new System.Windows.Forms.TextBox();
            this.txtPrkLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrkPrijavi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrkKorIme
            // 
            this.txtPrkKorIme.Location = new System.Drawing.Point(167, 122);
            this.txtPrkKorIme.Name = "txtPrkKorIme";
            this.txtPrkKorIme.Size = new System.Drawing.Size(180, 20);
            this.txtPrkKorIme.TabIndex = 0;
            // 
            // txtPrkLozinka
            // 
            this.txtPrkLozinka.Location = new System.Drawing.Point(167, 168);
            this.txtPrkLozinka.Name = "txtPrkLozinka";
            this.txtPrkLozinka.PasswordChar = '*';
            this.txtPrkLozinka.Size = new System.Drawing.Size(180, 20);
            this.txtPrkLozinka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // btnPrkPrijavi
            // 
            this.btnPrkPrijavi.Location = new System.Drawing.Point(167, 214);
            this.btnPrkPrijavi.Name = "btnPrkPrijavi";
            this.btnPrkPrijavi.Size = new System.Drawing.Size(180, 30);
            this.btnPrkPrijavi.TabIndex = 4;
            this.btnPrkPrijavi.Text = "Prijavi se";
            this.btnPrkPrijavi.UseVisualStyleBackColor = true;
            this.btnPrkPrijavi.Click += new System.EventHandler(this.btnPrkPrijavi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 88);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrijavaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 299);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrkPrijavi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrkLozinka);
            this.Controls.Add(this.txtPrkKorIme);
            this.Name = "frmPrijavaKorisnika";
            this.Text = "Banka Krvi | Prijava korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrkKorIme;
        private System.Windows.Forms.TextBox txtPrkLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrkPrijavi;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}