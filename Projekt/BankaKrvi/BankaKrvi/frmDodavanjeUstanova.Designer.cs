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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naziv.Location = new System.Drawing.Point(48, 62);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(37, 15);
            this.Naziv.TabIndex = 0;
            this.Naziv.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(48, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(48, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(48, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // txtDnuNaziv
            // 
            this.txtDnuNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDnuNaziv.Location = new System.Drawing.Point(168, 55);
            this.txtDnuNaziv.Multiline = true;
            this.txtDnuNaziv.Name = "txtDnuNaziv";
            this.txtDnuNaziv.Size = new System.Drawing.Size(173, 20);
            this.txtDnuNaziv.TabIndex = 4;
            this.txtDnuNaziv.MouseEnter += new System.EventHandler(this.txtDnuNaziv_MouseEnter);
            this.txtDnuNaziv.MouseLeave += new System.EventHandler(this.txtDnuNaziv_MouseLeave);
            // 
            // txtDnuAdresa
            // 
            this.txtDnuAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDnuAdresa.Location = new System.Drawing.Point(168, 101);
            this.txtDnuAdresa.Multiline = true;
            this.txtDnuAdresa.Name = "txtDnuAdresa";
            this.txtDnuAdresa.Size = new System.Drawing.Size(173, 20);
            this.txtDnuAdresa.TabIndex = 5;
            this.txtDnuAdresa.MouseEnter += new System.EventHandler(this.txtDnuAdresa_MouseEnter);
            this.txtDnuAdresa.MouseLeave += new System.EventHandler(this.txtDnuAdresa_MouseLeave);
            // 
            // txtDnuEmail
            // 
            this.txtDnuEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDnuEmail.Location = new System.Drawing.Point(168, 151);
            this.txtDnuEmail.Multiline = true;
            this.txtDnuEmail.Name = "txtDnuEmail";
            this.txtDnuEmail.Size = new System.Drawing.Size(173, 20);
            this.txtDnuEmail.TabIndex = 6;
            this.txtDnuEmail.MouseEnter += new System.EventHandler(this.txtDnuEmail_MouseEnter);
            this.txtDnuEmail.MouseLeave += new System.EventHandler(this.txtDnuEmail_MouseLeave);
            // 
            // txtDnuTelefon
            // 
            this.txtDnuTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDnuTelefon.Location = new System.Drawing.Point(168, 195);
            this.txtDnuTelefon.Multiline = true;
            this.txtDnuTelefon.Name = "txtDnuTelefon";
            this.txtDnuTelefon.Size = new System.Drawing.Size(173, 20);
            this.txtDnuTelefon.TabIndex = 7;
            this.txtDnuTelefon.MouseEnter += new System.EventHandler(this.txtDnuTelefon_MouseEnter);
            this.txtDnuTelefon.MouseLeave += new System.EventHandler(this.txtDnuTelefon_MouseLeave);
            // 
            // btnDodajUstanovu
            // 
            this.btnDodajUstanovu.BackColor = System.Drawing.Color.White;
            this.btnDodajUstanovu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajUstanovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajUstanovu.Location = new System.Drawing.Point(168, 243);
            this.btnDodajUstanovu.Name = "btnDodajUstanovu";
            this.btnDodajUstanovu.Size = new System.Drawing.Size(155, 36);
            this.btnDodajUstanovu.TabIndex = 8;
            this.btnDodajUstanovu.Text = "Dodaj Ustanovu";
            this.btnDodajUstanovu.UseVisualStyleBackColor = false;
            this.btnDodajUstanovu.Click += new System.EventHandler(this.btnDodajUstanovu_Click);
            this.btnDodajUstanovu.MouseEnter += new System.EventHandler(this.btnDodajUstanovu_MouseEnter);
            this.btnDodajUstanovu.MouseLeave += new System.EventHandler(this.btnDodajUstanovu_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtDnuNaziv);
            this.groupBox1.Controls.Add(this.btnDodajUstanovu);
            this.groupBox1.Controls.Add(this.Naziv);
            this.groupBox1.Controls.Add(this.txtDnuTelefon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDnuEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDnuAdresa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(367, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 325);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje ustanova:";
            // 
            // frmDodavanjeUstanova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDodavanjeUstanova";
            this.Load += new System.EventHandler(this.frmDodavanjeUstanova_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}