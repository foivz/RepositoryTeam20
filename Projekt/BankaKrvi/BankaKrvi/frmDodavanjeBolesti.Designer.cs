namespace BankaKrvi
{
    partial class frmDodavanjeBolesti
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
            this.txtDnbBolest = new System.Windows.Forms.TextBox();
            this.txtDnbNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajBolest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDnbBolest
            // 
            this.txtDnbBolest.Location = new System.Drawing.Point(124, 75);
            this.txtDnbBolest.Name = "txtDnbBolest";
            this.txtDnbBolest.ReadOnly = true;
            this.txtDnbBolest.Size = new System.Drawing.Size(188, 20);
            this.txtDnbBolest.TabIndex = 0;
            this.txtDnbBolest.Text = "Novi unos";
            // 
            // txtDnbNaziv
            // 
            this.txtDnbNaziv.Location = new System.Drawing.Point(124, 115);
            this.txtDnbNaziv.Name = "txtDnbNaziv";
            this.txtDnbNaziv.Size = new System.Drawing.Size(188, 20);
            this.txtDnbNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Šifra Bolesti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv";
            // 
            // btnDodajBolest
            // 
            this.btnDodajBolest.Location = new System.Drawing.Point(124, 166);
            this.btnDodajBolest.Name = "btnDodajBolest";
            this.btnDodajBolest.Size = new System.Drawing.Size(188, 23);
            this.btnDodajBolest.TabIndex = 4;
            this.btnDodajBolest.Text = "Dodaj Bolest";
            this.btnDodajBolest.UseVisualStyleBackColor = true;
            this.btnDodajBolest.Click += new System.EventHandler(this.btnDodajBolest_Click);
            // 
            // frmDodavanjeBolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 280);
            this.Controls.Add(this.btnDodajBolest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDnbNaziv);
            this.Controls.Add(this.txtDnbBolest);
            this.Name = "frmDodavanjeBolesti";
            this.Text = "frmDodavanjeBolesti";
            this.Load += new System.EventHandler(this.frmDodavanjeBolesti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDnbBolest;
        private System.Windows.Forms.TextBox txtDnbNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajBolest;
    }
}