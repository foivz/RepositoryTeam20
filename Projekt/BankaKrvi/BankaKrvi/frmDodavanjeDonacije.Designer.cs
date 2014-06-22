namespace BankaKrvi
{
    partial class frmDodavanjeDonacije
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
            this.cboxDndZaposlenik = new System.Windows.Forms.ComboBox();
            this.cboxDndHladnjak = new System.Windows.Forms.ComboBox();
            this.cboxDndPacijent = new System.Windows.Forms.ComboBox();
            this.txtDndNapomena = new System.Windows.Forms.TextBox();
            this.dtpDndVrijeme = new System.Windows.Forms.DateTimePicker();
            this.txtDndDonacija = new System.Windows.Forms.TextBox();
            this.btnDndDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxDndZaposlenik
            // 
            this.cboxDndZaposlenik.FormattingEnabled = true;
            this.cboxDndZaposlenik.Location = new System.Drawing.Point(213, 310);
            this.cboxDndZaposlenik.Name = "cboxDndZaposlenik";
            this.cboxDndZaposlenik.Size = new System.Drawing.Size(217, 21);
            this.cboxDndZaposlenik.TabIndex = 25;
            // 
            // cboxDndHladnjak
            // 
            this.cboxDndHladnjak.FormattingEnabled = true;
            this.cboxDndHladnjak.Location = new System.Drawing.Point(213, 268);
            this.cboxDndHladnjak.Name = "cboxDndHladnjak";
            this.cboxDndHladnjak.Size = new System.Drawing.Size(217, 21);
            this.cboxDndHladnjak.TabIndex = 24;
            // 
            // cboxDndPacijent
            // 
            this.cboxDndPacijent.FormattingEnabled = true;
            this.cboxDndPacijent.Location = new System.Drawing.Point(213, 226);
            this.cboxDndPacijent.Name = "cboxDndPacijent";
            this.cboxDndPacijent.Size = new System.Drawing.Size(217, 21);
            this.cboxDndPacijent.TabIndex = 23;
            // 
            // txtDndNapomena
            // 
            this.txtDndNapomena.Location = new System.Drawing.Point(213, 147);
            this.txtDndNapomena.Multiline = true;
            this.txtDndNapomena.Name = "txtDndNapomena";
            this.txtDndNapomena.Size = new System.Drawing.Size(217, 58);
            this.txtDndNapomena.TabIndex = 22;
            // 
            // dtpDndVrijeme
            // 
            this.dtpDndVrijeme.Location = new System.Drawing.Point(213, 106);
            this.dtpDndVrijeme.Name = "dtpDndVrijeme";
            this.dtpDndVrijeme.Size = new System.Drawing.Size(217, 20);
            this.dtpDndVrijeme.TabIndex = 21;
            // 
            // txtDndDonacija
            // 
            this.txtDndDonacija.Location = new System.Drawing.Point(213, 65);
            this.txtDndDonacija.Name = "txtDndDonacija";
            this.txtDndDonacija.ReadOnly = true;
            this.txtDndDonacija.Size = new System.Drawing.Size(217, 20);
            this.txtDndDonacija.TabIndex = 20;
            // 
            // btnDndDodaj
            // 
            this.btnDndDodaj.Location = new System.Drawing.Point(213, 352);
            this.btnDndDodaj.Name = "btnDndDodaj";
            this.btnDndDodaj.Size = new System.Drawing.Size(217, 23);
            this.btnDndDodaj.TabIndex = 19;
            this.btnDndDodaj.Text = "Dodaj";
            this.btnDndDodaj.UseVisualStyleBackColor = true;
            this.btnDndDodaj.Click += new System.EventHandler(this.btnDndDodaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Zaposlenik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hladnjak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pacijent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Napomena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vrijeme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Šifra donacije";
            // 
            // frmDodavanjeDonacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.cboxDndZaposlenik);
            this.Controls.Add(this.cboxDndHladnjak);
            this.Controls.Add(this.cboxDndPacijent);
            this.Controls.Add(this.txtDndNapomena);
            this.Controls.Add(this.dtpDndVrijeme);
            this.Controls.Add(this.txtDndDonacija);
            this.Controls.Add(this.btnDndDodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodavanjeDonacije";
            this.Text = "Dodavanje  donacije";
            this.Load += new System.EventHandler(this.frmDodavanjeDonacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxDndZaposlenik;
        private System.Windows.Forms.ComboBox cboxDndHladnjak;
        private System.Windows.Forms.ComboBox cboxDndPacijent;
        private System.Windows.Forms.TextBox txtDndNapomena;
        private System.Windows.Forms.DateTimePicker dtpDndVrijeme;
        private System.Windows.Forms.TextBox txtDndDonacija;
        private System.Windows.Forms.Button btnDndDodaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}