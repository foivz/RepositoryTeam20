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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDnbBolest
            // 
            this.txtDnbBolest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDnbBolest.Location = new System.Drawing.Point(94, 54);
            this.txtDnbBolest.Name = "txtDnbBolest";
            this.txtDnbBolest.ReadOnly = true;
            this.txtDnbBolest.Size = new System.Drawing.Size(188, 21);
            this.txtDnbBolest.TabIndex = 0;
            this.txtDnbBolest.Text = "Novi unos";
            // 
            // txtDnbNaziv
            // 
            this.txtDnbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDnbNaziv.Location = new System.Drawing.Point(94, 94);
            this.txtDnbNaziv.Multiline = true;
            this.txtDnbNaziv.Name = "txtDnbNaziv";
            this.txtDnbNaziv.Size = new System.Drawing.Size(188, 20);
            this.txtDnbNaziv.TabIndex = 1;
            this.txtDnbNaziv.MouseEnter += new System.EventHandler(this.txtDnbNaziv_MouseEnter);
            this.txtDnbNaziv.MouseLeave += new System.EventHandler(this.txtDnbNaziv_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Šifra Bolesti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv";
            // 
            // btnDodajBolest
            // 
            this.btnDodajBolest.BackColor = System.Drawing.Color.White;
            this.btnDodajBolest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajBolest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajBolest.Location = new System.Drawing.Point(118, 144);
            this.btnDodajBolest.Name = "btnDodajBolest";
            this.btnDodajBolest.Size = new System.Drawing.Size(131, 31);
            this.btnDodajBolest.TabIndex = 4;
            this.btnDodajBolest.Text = "Dodaj Bolest";
            this.btnDodajBolest.UseVisualStyleBackColor = false;
            this.btnDodajBolest.Click += new System.EventHandler(this.btnDodajBolest_Click);
            this.btnDodajBolest.MouseEnter += new System.EventHandler(this.btnDodajBolest_MouseEnter);
            this.btnDodajBolest.MouseLeave += new System.EventHandler(this.btnDodajBolest_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDodajBolest);
            this.groupBox1.Controls.Add(this.txtDnbBolest);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDnbNaziv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(416, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 229);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje bolesti:";
            // 
            // frmDodavanjeBolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDodavanjeBolesti";
            this.Text = "frmDodavanjeBolesti";
            this.Load += new System.EventHandler(this.frmDodavanjeBolesti_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDnbBolest;
        private System.Windows.Forms.TextBox txtDnbNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajBolest;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}