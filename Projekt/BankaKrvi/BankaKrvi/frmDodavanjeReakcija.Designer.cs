namespace BankaKrvi
{
    partial class frmDodavanjeReakcija
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
            this.txtDnrReakcija = new System.Windows.Forms.TextBox();
            this.txtDnrNaziv = new System.Windows.Forms.TextBox();
            this.btnDnrDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra Reakcije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(75, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // txtDnrReakcija
            // 
            this.txtDnrReakcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDnrReakcija.Location = new System.Drawing.Point(126, 60);
            this.txtDnrReakcija.Name = "txtDnrReakcija";
            this.txtDnrReakcija.ReadOnly = true;
            this.txtDnrReakcija.Size = new System.Drawing.Size(158, 21);
            this.txtDnrReakcija.TabIndex = 2;
            this.txtDnrReakcija.Text = "Novi unos";
            // 
            // txtDnrNaziv
            // 
            this.txtDnrNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDnrNaziv.Location = new System.Drawing.Point(126, 96);
            this.txtDnrNaziv.Multiline = true;
            this.txtDnrNaziv.Name = "txtDnrNaziv";
            this.txtDnrNaziv.Size = new System.Drawing.Size(158, 20);
            this.txtDnrNaziv.TabIndex = 3;
            this.txtDnrNaziv.MouseEnter += new System.EventHandler(this.txtDnrNaziv_MouseEnter);
            this.txtDnrNaziv.MouseLeave += new System.EventHandler(this.txtDnrNaziv_MouseLeave);
            // 
            // btnDnrDodaj
            // 
            this.btnDnrDodaj.BackColor = System.Drawing.Color.White;
            this.btnDnrDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDnrDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDnrDodaj.Location = new System.Drawing.Point(142, 152);
            this.btnDnrDodaj.Name = "btnDnrDodaj";
            this.btnDnrDodaj.Size = new System.Drawing.Size(142, 34);
            this.btnDnrDodaj.TabIndex = 4;
            this.btnDnrDodaj.Text = "Dodaj Reakciju";
            this.btnDnrDodaj.UseVisualStyleBackColor = false;
            this.btnDnrDodaj.Click += new System.EventHandler(this.btnDnrDodaj_Click);
            this.btnDnrDodaj.MouseEnter += new System.EventHandler(this.btnDnrDodaj_MouseEnter);
            this.btnDnrDodaj.MouseLeave += new System.EventHandler(this.btnDnrDodaj_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtDnrReakcija);
            this.groupBox1.Controls.Add(this.btnDnrDodaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDnrNaziv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(473, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje reakcije: ";
            // 
            // frmDodavanjeReakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDodavanjeReakcija";
            this.Text = "frmDodavanjeReakcija";
            this.Load += new System.EventHandler(this.frmDodavanjeReakcija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDnrReakcija;
        private System.Windows.Forms.TextBox txtDnrNaziv;
        private System.Windows.Forms.Button btnDnrDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}