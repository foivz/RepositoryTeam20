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
            this.dgvTransfuzije.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransfuzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfuzije.Location = new System.Drawing.Point(15, 24);
            this.dgvTransfuzije.MultiSelect = false;
            this.dgvTransfuzije.Name = "dgvTransfuzije";
            this.dgvTransfuzije.RowHeadersVisible = false;
            this.dgvTransfuzije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransfuzije.Size = new System.Drawing.Size(955, 153);
            this.dgvTransfuzije.TabIndex = 3;
            // 
            // btnAzurirajTransfuzije
            // 
            this.btnAzurirajTransfuzije.BackColor = System.Drawing.Color.White;
            this.btnAzurirajTransfuzije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajTransfuzije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajTransfuzije.Location = new System.Drawing.Point(268, 566);
            this.btnAzurirajTransfuzije.Name = "btnAzurirajTransfuzije";
            this.btnAzurirajTransfuzije.Size = new System.Drawing.Size(184, 32);
            this.btnAzurirajTransfuzije.TabIndex = 4;
            this.btnAzurirajTransfuzije.Text = "Ažuriraj transfuzije";
            this.btnAzurirajTransfuzije.UseVisualStyleBackColor = false;
            this.btnAzurirajTransfuzije.Click += new System.EventHandler(this.btnAzurirajTransfuzije_Click);
            this.btnAzurirajTransfuzije.MouseEnter += new System.EventHandler(this.btnAzurirajTransfuzije_MouseEnter);
            this.btnAzurirajTransfuzije.MouseLeave += new System.EventHandler(this.btnAzurirajTransfuzije_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transfuzije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
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
            this.dgvDonacije.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonacije.Location = new System.Drawing.Point(15, 206);
            this.dgvDonacije.MultiSelect = false;
            this.dgvDonacije.Name = "dgvDonacije";
            this.dgvDonacije.RowHeadersVisible = false;
            this.dgvDonacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonacije.Size = new System.Drawing.Size(955, 155);
            this.dgvDonacije.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
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
            this.dgvReakcije.BackgroundColor = System.Drawing.Color.White;
            this.dgvReakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReakcije.Location = new System.Drawing.Point(15, 396);
            this.dgvReakcije.MultiSelect = false;
            this.dgvReakcije.Name = "dgvReakcije";
            this.dgvReakcije.RowHeadersVisible = false;
            this.dgvReakcije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReakcije.Size = new System.Drawing.Size(955, 150);
            this.dgvReakcije.TabIndex = 3;
            // 
            // btnPrikaziPosdatke
            // 
            this.btnPrikaziPosdatke.BackColor = System.Drawing.Color.White;
            this.btnPrikaziPosdatke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziPosdatke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikaziPosdatke.Location = new System.Drawing.Point(15, 566);
            this.btnPrikaziPosdatke.Name = "btnPrikaziPosdatke";
            this.btnPrikaziPosdatke.Size = new System.Drawing.Size(184, 32);
            this.btnPrikaziPosdatke.TabIndex = 7;
            this.btnPrikaziPosdatke.Text = "Prikaži podatke";
            this.btnPrikaziPosdatke.UseVisualStyleBackColor = false;
            this.btnPrikaziPosdatke.Click += new System.EventHandler(this.btnPrikaziPosdatke_Click);
            this.btnPrikaziPosdatke.MouseEnter += new System.EventHandler(this.btnPrikaziPosdatke_MouseEnter);
            this.btnPrikaziPosdatke.MouseLeave += new System.EventHandler(this.btnPrikaziPosdatke_MouseLeave);
            // 
            // frmPregledTransfuzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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