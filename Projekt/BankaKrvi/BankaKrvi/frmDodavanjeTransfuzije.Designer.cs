namespace BankaKrvi
{
    partial class frmDodavanjeTransfuzije
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
            this.btnDodajTransfuziju = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDonacije = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDodajDonaciju = new System.Windows.Forms.ComboBox();
            this.btnDodajDonaciju = new System.Windows.Forms.Button();
            this.dgvReakcije = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDodajReakcije = new System.Windows.Forms.ComboBox();
            this.btnDodajReakciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajTransfuziju
            // 
            this.btnDodajTransfuziju.BackColor = System.Drawing.Color.White;
            this.btnDodajTransfuziju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajTransfuziju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajTransfuziju.Location = new System.Drawing.Point(36, 303);
            this.btnDodajTransfuziju.Name = "btnDodajTransfuziju";
            this.btnDodajTransfuziju.Size = new System.Drawing.Size(149, 46);
            this.btnDodajTransfuziju.TabIndex = 0;
            this.btnDodajTransfuziju.Text = "Dodaj transfuziju";
            this.btnDodajTransfuziju.UseVisualStyleBackColor = false;
            this.btnDodajTransfuziju.MouseEnter += new System.EventHandler(this.btnDodajTransfuziju_MouseEnter);
            this.btnDodajTransfuziju.MouseLeave += new System.EventHandler(this.btnDodajTransfuziju_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 80);
            this.textBox1.TabIndex = 1;
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Povijest bolesti:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 153);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.MouseEnter += new System.EventHandler(this.textBox2_MouseEnter);
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 196);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.MouseEnter += new System.EventHandler(this.textBox3_MouseEnter);
            this.textBox3.MouseLeave += new System.EventHandler(this.textBox3_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Količina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Odaberi donaciju:";
            // 
            // dgvDonacije
            // 
            this.dgvDonacije.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonacije.Location = new System.Drawing.Point(461, 38);
            this.dgvDonacije.Name = "dgvDonacije";
            this.dgvDonacije.Size = new System.Drawing.Size(688, 173);
            this.dgvDonacije.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(457, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Donacije:";
            // 
            // cmbDodajDonaciju
            // 
            this.cmbDodajDonaciju.FormattingEnabled = true;
            this.cmbDodajDonaciju.Location = new System.Drawing.Point(590, 235);
            this.cmbDodajDonaciju.Name = "cmbDodajDonaciju";
            this.cmbDodajDonaciju.Size = new System.Drawing.Size(188, 23);
            this.cmbDodajDonaciju.TabIndex = 10;
            // 
            // btnDodajDonaciju
            // 
            this.btnDodajDonaciju.BackColor = System.Drawing.Color.White;
            this.btnDodajDonaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajDonaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDonaciju.Location = new System.Drawing.Point(806, 233);
            this.btnDodajDonaciju.Name = "btnDodajDonaciju";
            this.btnDodajDonaciju.Size = new System.Drawing.Size(149, 46);
            this.btnDodajDonaciju.TabIndex = 11;
            this.btnDodajDonaciju.Text = "Dodaj donaciju";
            this.btnDodajDonaciju.UseVisualStyleBackColor = false;
            this.btnDodajDonaciju.MouseEnter += new System.EventHandler(this.btnDodajDonaciju_MouseEnter);
            this.btnDodajDonaciju.MouseLeave += new System.EventHandler(this.btnDodajDonaciju_MouseLeave);
            // 
            // dgvReakcije
            // 
            this.dgvReakcije.BackgroundColor = System.Drawing.Color.White;
            this.dgvReakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReakcije.Location = new System.Drawing.Point(461, 303);
            this.dgvReakcije.Name = "dgvReakcije";
            this.dgvReakcije.Size = new System.Drawing.Size(688, 173);
            this.dgvReakcije.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(457, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Reakcije:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(457, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Odaberi reakciju:";
            // 
            // cmbDodajReakcije
            // 
            this.cmbDodajReakcije.FormattingEnabled = true;
            this.cmbDodajReakcije.Location = new System.Drawing.Point(590, 498);
            this.cmbDodajReakcije.Name = "cmbDodajReakcije";
            this.cmbDodajReakcije.Size = new System.Drawing.Size(188, 23);
            this.cmbDodajReakcije.TabIndex = 15;
            // 
            // btnDodajReakciju
            // 
            this.btnDodajReakciju.BackColor = System.Drawing.Color.White;
            this.btnDodajReakciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajReakciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajReakciju.Location = new System.Drawing.Point(806, 496);
            this.btnDodajReakciju.Name = "btnDodajReakciju";
            this.btnDodajReakciju.Size = new System.Drawing.Size(149, 46);
            this.btnDodajReakciju.TabIndex = 16;
            this.btnDodajReakciju.Text = "Dodaj reakciju";
            this.btnDodajReakciju.UseVisualStyleBackColor = false;
            this.btnDodajReakciju.MouseEnter += new System.EventHandler(this.btnDodajReakciju_MouseEnter);
            this.btnDodajReakciju.MouseLeave += new System.EventHandler(this.btnDodajReakciju_MouseLeave);
            // 
            // frmDodavanjeTransfuzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1176, 750);
            this.Controls.Add(this.btnDodajReakciju);
            this.Controls.Add(this.cmbDodajReakcije);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvReakcije);
            this.Controls.Add(this.btnDodajDonaciju);
            this.Controls.Add(this.cmbDodajDonaciju);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDonacije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDodajTransfuziju);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmDodavanjeTransfuzije";
            this.Text = "Dodavanje transfuzije";
            this.Load += new System.EventHandler(this.frmDodavanjeTransfuzije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReakcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajTransfuziju;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDonacije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDodajDonaciju;
        private System.Windows.Forms.Button btnDodajDonaciju;
        private System.Windows.Forms.DataGridView dgvReakcije;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDodajReakcije;
        private System.Windows.Forms.Button btnDodajReakciju;
    }
}