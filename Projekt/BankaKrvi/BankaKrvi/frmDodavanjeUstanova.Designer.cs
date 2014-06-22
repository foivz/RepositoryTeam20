namespace BankaKrvi
{
    partial class frmDodavanjeUstanova
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
            this.Naziv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDnuNaziv = new System.Windows.Forms.TextBox();
            this.txtDnuAdresa = new System.Windows.Forms.TextBox();
            this.txtDnuEmail = new System.Windows.Forms.TextBox();
            this.txtDnuTelefon = new System.Windows.Forms.TextBox();
            this.btnDodajUstanovu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(64, 55);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(34, 13);
            this.Naziv.TabIndex = 0;
            this.Naziv.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // txtDnuNaziv
            // 
            this.txtDnuNaziv.Location = new System.Drawing.Point(184, 48);
            this.txtDnuNaziv.Name = "txtDnuNaziv";
            this.txtDnuNaziv.Size = new System.Drawing.Size(173, 20);
            this.txtDnuNaziv.TabIndex = 4;
            // 
            // txtDnuAdresa
            // 
            this.txtDnuAdresa.Location = new System.Drawing.Point(184, 94);
            this.txtDnuAdresa.Name = "txtDnuAdresa";
            this.txtDnuAdresa.Size = new System.Drawing.Size(173, 20);
            this.txtDnuAdresa.TabIndex = 5;
            // 
            // txtDnuEmail
            // 
            this.txtDnuEmail.Location = new System.Drawing.Point(184, 144);
            this.txtDnuEmail.Name = "txtDnuEmail";
            this.txtDnuEmail.Size = new System.Drawing.Size(173, 20);
            this.txtDnuEmail.TabIndex = 6;
            // 
            // txtDnuTelefon
            // 
            this.txtDnuTelefon.Location = new System.Drawing.Point(184, 188);
            this.txtDnuTelefon.Name = "txtDnuTelefon";
            this.txtDnuTelefon.Size = new System.Drawing.Size(173, 20);
            this.txtDnuTelefon.TabIndex = 7;
            // 
            // btnDodajUstanovu
            // 
            this.btnDodajUstanovu.Location = new System.Drawing.Point(184, 248);
            this.btnDodajUstanovu.Name = "btnDodajUstanovu";
            this.btnDodajUstanovu.Size = new System.Drawing.Size(173, 23);
            this.btnDodajUstanovu.TabIndex = 8;
            this.btnDodajUstanovu.Text = "Dodaj Ustanovu";
            this.btnDodajUstanovu.UseVisualStyleBackColor = true;
            this.btnDodajUstanovu.Click += new System.EventHandler(this.btnDodajUstanovu_Click);
            // 
            // frmDodavanjeUstanova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 339);
            this.Controls.Add(this.btnDodajUstanovu);
            this.Controls.Add(this.txtDnuTelefon);
            this.Controls.Add(this.txtDnuEmail);
            this.Controls.Add(this.txtDnuAdresa);
            this.Controls.Add(this.txtDnuNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Naziv);
            this.Name = "frmDodavanjeUstanova";
            this.Load += new System.EventHandler(this.frmDodavanjeUstanova_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDnuNaziv;
        private System.Windows.Forms.TextBox txtDnuAdresa;
        private System.Windows.Forms.TextBox txtDnuEmail;
        private System.Windows.Forms.TextBox txtDnuTelefon;
        private System.Windows.Forms.Button btnDodajUstanovu;
    }
}