namespace BankaKrvi
{
    partial class frmPregledTransfuzija
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
            this.dgvTransfuzije = new System.Windows.Forms.DataGridView();
            this.btnAzurirajTransfuzije = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDonacije = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvReakcije = new System.Windows.Forms.DataGridView();
            this.btnPrikaziPosdatke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfuzije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransfuzije
            // 
            this.dgvTransfuzije.AllowUserToAddRows = false;
            this.dgvTransfuzije.AllowUserToDeleteRows = false;
            this.dgvTransfuzije.AllowUserToOrderColumns = true;
            this.dgvTransfuzije.AllowUserToResizeColumns = false;
            this.dgvTransfuzije.AllowUserToResizeRows = false;
            this.dgvTransfuzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfuzije.Location = new System.Drawing.Point(15, 38);
            this.dgvTransfuzije.MultiSelect = false;
            this.dgvTransfuzije.Name = "dgvTransfuzije";
            this.dgvTransfuzije.RowHeadersVisible = false;
            this.dgvTransfuzije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransfuzije.Size = new System.Drawing.Size(955, 166);
            this.dgvTransfuzije.TabIndex = 3;
            // 
            // btnAzurirajTransfuzije
            // 
            this.btnAzurirajTransfuzije.Location = new System.Drawing.Point(183, 611);
            this.btnAzurirajTransfuzije.Name = "btnAzurirajTransfuzije";
            this.btnAzurirajTransfuzije.Size = new System.Drawing.Size(101, 23);
            this.btnAzurirajTransfuzije.TabIndex = 4;
            this.btnAzurirajTransfuzije.Text = "Ažuriraj transfuzije";
            this.btnAzurirajTransfuzije.UseVisualStyleBackColor = true;
            this.btnAzurirajTransfuzije.Click += new System.EventHandler(this.btnAzurirajTransfuzije_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transfuzije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Donacije";
            // 
            // dgvDonacije
            // 
            this.dgvDonacije.AllowUserToAddRows = false;
            this.dgvDonacije.AllowUserToDeleteRows = false;
            this.dgvDonacije.AllowUserToOrderColumns = true;
            this.dgvDonacije.AllowUserToResizeColumns = false;
            this.dgvDonacije.AllowUserToResizeRows = false;
            this.dgvDonacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonacije.Location = new System.Drawing.Point(15, 227);
            this.dgvDonacije.MultiSelect = false;
            this.dgvDonacije.Name = "dgvDonacije";
            this.dgvDonacije.RowHeadersVisible = false;
            this.dgvDonacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonacije.Size = new System.Drawing.Size(955, 166);
            this.dgvDonacije.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reakcije";
            // 
            // dgvReakcije
            // 
            this.dgvReakcije.AllowUserToAddRows = false;
            this.dgvReakcije.AllowUserToDeleteRows = false;
            this.dgvReakcije.AllowUserToOrderColumns = true;
            this.dgvReakcije.AllowUserToResizeColumns = false;
            this.dgvReakcije.AllowUserToResizeRows = false;
            this.dgvReakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReakcije.Location = new System.Drawing.Point(15, 423);
            this.dgvReakcije.MultiSelect = false;
            this.dgvReakcije.Name = "dgvReakcije";
            this.dgvReakcije.RowHeadersVisible = false;
            this.dgvReakcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReakcije.Size = new System.Drawing.Size(955, 166);
            this.dgvReakcije.TabIndex = 3;
            // 
            // btnPrikaziPosdatke
            // 
            this.btnPrikaziPosdatke.Location = new System.Drawing.Point(18, 611);
            this.btnPrikaziPosdatke.Name = "btnPrikaziPosdatke";
            this.btnPrikaziPosdatke.Size = new System.Drawing.Size(127, 23);
            this.btnPrikaziPosdatke.TabIndex = 7;
            this.btnPrikaziPosdatke.Text = "Prikaži podatke";
            this.btnPrikaziPosdatke.UseVisualStyleBackColor = true;
            this.btnPrikaziPosdatke.Click += new System.EventHandler(this.btnPrikaziPosdatke_Click);
            // 
            // frmPregledTransfuzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnPrikaziPosdatke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAzurirajTransfuzije);
            this.Controls.Add(this.dgvReakcije);
            this.Controls.Add(this.dgvDonacije);
            this.Controls.Add(this.dgvTransfuzije);
            this.Name = "frmPregledTransfuzija";
            this.Text = "frmPregledTransfuzija";
            this.Load += new System.EventHandler(this.frmPregledTransfuzija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfuzije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReakcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransfuzije;
        private System.Windows.Forms.Button btnAzurirajTransfuzije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDonacije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReakcije;
        private System.Windows.Forms.Button btnPrikaziPosdatke;
    }
}