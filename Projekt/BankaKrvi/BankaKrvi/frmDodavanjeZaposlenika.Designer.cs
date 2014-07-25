namespace BankaKrvi
{
    partial class frmDodavanjeZaposlenika
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxZapIme = new System.Windows.Forms.TextBox();
            this.tboxZapPrezime = new System.Windows.Forms.TextBox();
            this.tboxZapKorIme = new System.Windows.Forms.TextBox();
            this.tboxZapLozinka = new System.Windows.Forms.TextBox();
            this.tboxZapEmail = new System.Windows.Forms.TextBox();
            this.tboxZapTelefon = new System.Windows.Forms.TextBox();
            this.cboxZapTip = new System.Windows.Forms.ComboBox();
            this.cboxZapUstanova = new System.Windows.Forms.ComboBox();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(43, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(43, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Korisničko ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(43, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lozinka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(444, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(444, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(444, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tip zaposlenika";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(444, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ustanova";
            // 
            // tboxZapIme
            // 
            this.tboxZapIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxZapIme.Location = new System.Drawing.Point(163, 61);
            this.tboxZapIme.Multiline = true;
            this.tboxZapIme.Name = "tboxZapIme";
            this.tboxZapIme.Size = new System.Drawing.Size(226, 20);
            this.tboxZapIme.TabIndex = 8;
            this.tboxZapIme.MouseEnter += new System.EventHandler(this.tboxZapIme_MouseEnter);
            this.tboxZapIme.MouseLeave += new System.EventHandler(this.tboxZapIme_MouseLeave);
            // 
            // tboxZapPrezime
            // 
            this.tboxZapPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxZapPrezime.Location = new System.Drawing.Point(163, 101);
            this.tboxZapPrezime.Multiline = true;
            this.tboxZapPrezime.Name = "tboxZapPrezime";
            this.tboxZapPrezime.Size = new System.Drawing.Size(226, 20);
            this.tboxZapPrezime.TabIndex = 9;
            this.tboxZapPrezime.MouseEnter += new System.EventHandler(this.tboxZapPrezime_MouseEnter);
            this.tboxZapPrezime.MouseLeave += new System.EventHandler(this.tboxZapPrezime_MouseLeave);
            // 
            // tboxZapKorIme
            // 
            this.tboxZapKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxZapKorIme.Location = new System.Drawing.Point(163, 142);
            this.tboxZapKorIme.Multiline = true;
            this.tboxZapKorIme.Name = "tboxZapKorIme";
            this.tboxZapKorIme.Size = new System.Drawing.Size(226, 20);
            this.tboxZapKorIme.TabIndex = 10;
            this.tboxZapKorIme.MouseEnter += new System.EventHandler(this.tboxZapKorIme_MouseEnter);
            this.tboxZapKorIme.MouseLeave += new System.EventHandler(this.tboxZapKorIme_MouseLeave);
            // 
            // tboxZapLozinka
            // 
            this.tboxZapLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxZapLozinka.Location = new System.Drawing.Point(163, 182);
            this.tboxZapLozinka.Multiline = true;
            this.tboxZapLozinka.Name = "tboxZapLozinka";
            this.tboxZapLozinka.Size = new System.Drawing.Size(226, 20);
            this.tboxZapLozinka.TabIndex = 11;
            this.tboxZapLozinka.MouseEnter += new System.EventHandler(this.tboxZapLozinka_MouseEnter);
            this.tboxZapLozinka.MouseLeave += new System.EventHandler(this.tboxZapLozinka_MouseLeave);
            // 
            // tboxZapEmail
            // 
            this.tboxZapEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxZapEmail.Location = new System.Drawing.Point(561, 57);
            this.tboxZapEmail.Multiline = true;
            this.tboxZapEmail.Name = "tboxZapEmail";
            this.tboxZapEmail.Size = new System.Drawing.Size(226, 20);
            this.tboxZapEmail.TabIndex = 12;
            this.tboxZapEmail.MouseEnter += new System.EventHandler(this.tboxZapEmail_MouseEnter);
            this.tboxZapEmail.MouseLeave += new System.EventHandler(this.tboxZapEmail_MouseLeave);
            // 
            // tboxZapTelefon
            // 
            this.tboxZapTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxZapTelefon.Location = new System.Drawing.Point(561, 101);
            this.tboxZapTelefon.Multiline = true;
            this.tboxZapTelefon.Name = "tboxZapTelefon";
            this.tboxZapTelefon.Size = new System.Drawing.Size(226, 20);
            this.tboxZapTelefon.TabIndex = 13;
            this.tboxZapTelefon.MouseEnter += new System.EventHandler(this.tboxZapTelefon_MouseEnter);
            this.tboxZapTelefon.MouseLeave += new System.EventHandler(this.tboxZapTelefon_MouseLeave);
            // 
            // cboxZapTip
            // 
            this.cboxZapTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxZapTip.FormattingEnabled = true;
            this.cboxZapTip.Location = new System.Drawing.Point(561, 142);
            this.cboxZapTip.Name = "cboxZapTip";
            this.cboxZapTip.Size = new System.Drawing.Size(226, 23);
            this.cboxZapTip.TabIndex = 14;
            // 
            // cboxZapUstanova
            // 
            this.cboxZapUstanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxZapUstanova.FormattingEnabled = true;
            this.cboxZapUstanova.Location = new System.Drawing.Point(561, 181);
            this.cboxZapUstanova.Name = "cboxZapUstanova";
            this.cboxZapUstanova.Size = new System.Drawing.Size(226, 23);
            this.cboxZapUstanova.TabIndex = 15;
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.BackColor = System.Drawing.Color.White;
            this.btnDodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(299, 258);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(226, 34);
            this.btnDodajZaposlenika.TabIndex = 16;
            this.btnDodajZaposlenika.Text = "Dodaj novog zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = false;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            this.btnDodajZaposlenika.MouseEnter += new System.EventHandler(this.btnDodajZaposlenika_MouseEnter);
            this.btnDodajZaposlenika.MouseLeave += new System.EventHandler(this.btnDodajZaposlenika_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.tboxZapPrezime);
            this.groupBox1.Controls.Add(this.btnDodajZaposlenika);
            this.groupBox1.Controls.Add(this.cboxZapUstanova);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxZapTip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxZapLozinka);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tboxZapKorIme);
            this.groupBox1.Controls.Add(this.tboxZapTelefon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tboxZapEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tboxZapIme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(150, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 310);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje novog zaposlenika:";
            // 
            // frmDodavanjeZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDodavanjeZaposlenika";
            this.Load += new System.EventHandler(this.frmDodavanjeZaposlenika_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxZapIme;
        private System.Windows.Forms.TextBox tboxZapPrezime;
        private System.Windows.Forms.TextBox tboxZapKorIme;
        private System.Windows.Forms.TextBox tboxZapLozinka;
        private System.Windows.Forms.TextBox tboxZapEmail;
        private System.Windows.Forms.TextBox tboxZapTelefon;
        private System.Windows.Forms.ComboBox cboxZapTip;
        private System.Windows.Forms.ComboBox cboxZapUstanova;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}