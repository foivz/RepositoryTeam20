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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra Reakcije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // txtDnrReakcija
            // 
            this.txtDnrReakcija.Location = new System.Drawing.Point(106, 42);
            this.txtDnrReakcija.Name = "txtDnrReakcija";
            this.txtDnrReakcija.ReadOnly = true;
            this.txtDnrReakcija.Size = new System.Drawing.Size(158, 20);
            this.txtDnrReakcija.TabIndex = 2;
            this.txtDnrReakcija.Text = "Novi unos";
            // 
            // txtDnrNaziv
            // 
            this.txtDnrNaziv.Location = new System.Drawing.Point(106, 78);
            this.txtDnrNaziv.Name = "txtDnrNaziv";
            this.txtDnrNaziv.Size = new System.Drawing.Size(158, 20);
            this.txtDnrNaziv.TabIndex = 3;
            // 
            // btnDnrDodaj
            // 
            this.btnDnrDodaj.Location = new System.Drawing.Point(106, 137);
            this.btnDnrDodaj.Name = "btnDnrDodaj";
            this.btnDnrDodaj.Size = new System.Drawing.Size(158, 23);
            this.btnDnrDodaj.TabIndex = 4;
            this.btnDnrDodaj.Text = "Dodaj Reakciju";
            this.btnDnrDodaj.UseVisualStyleBackColor = true;
            this.btnDnrDodaj.Click += new System.EventHandler(this.btnDnrDodaj_Click);
            // 
            // frmDodavanjeReakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 273);
            this.Controls.Add(this.btnDnrDodaj);
            this.Controls.Add(this.txtDnrNaziv);
            this.Controls.Add(this.txtDnrReakcija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodavanjeReakcija";
            this.Text = "frmDodavanjeReakcija";
            this.Load += new System.EventHandler(this.frmDodavanjeReakcija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDnrReakcija;
        private System.Windows.Forms.TextBox txtDnrNaziv;
        private System.Windows.Forms.Button btnDnrDodaj;
    }
}