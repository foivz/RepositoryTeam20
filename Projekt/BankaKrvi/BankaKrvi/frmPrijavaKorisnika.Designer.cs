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
            this.txtPrkKorIme = new System.Windows.Forms.TextBox();
            this.txtPrkLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrkPrijavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrkKorIme
            // 
            this.txtPrkKorIme.Location = new System.Drawing.Point(128, 79);
            this.txtPrkKorIme.Name = "txtPrkKorIme";
            this.txtPrkKorIme.Size = new System.Drawing.Size(180, 20);
            this.txtPrkKorIme.TabIndex = 0;
            // 
            // txtPrkLozinka
            // 
            this.txtPrkLozinka.Location = new System.Drawing.Point(128, 125);
            this.txtPrkLozinka.Name = "txtPrkLozinka";
            this.txtPrkLozinka.PasswordChar = '*';
            this.txtPrkLozinka.Size = new System.Drawing.Size(180, 20);
            this.txtPrkLozinka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // btnPrkPrijavi
            // 
            this.btnPrkPrijavi.Location = new System.Drawing.Point(196, 178);
            this.btnPrkPrijavi.Name = "btnPrkPrijavi";
            this.btnPrkPrijavi.Size = new System.Drawing.Size(112, 23);
            this.btnPrkPrijavi.TabIndex = 4;
            this.btnPrkPrijavi.Text = "Prijavi se";
            this.btnPrkPrijavi.UseVisualStyleBackColor = true;
            this.btnPrkPrijavi.Click += new System.EventHandler(this.btnPrkPrijavi_Click);
            // 
            // frmPrijavaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 266);
            this.Controls.Add(this.btnPrkPrijavi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrkLozinka);
            this.Controls.Add(this.txtPrkKorIme);
            this.Name = "frmPrijavaKorisnika";
            this.Text = "Banka Krvi | Prijava korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrkKorIme;
        private System.Windows.Forms.TextBox txtPrkLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrkPrijavi;

    }
}