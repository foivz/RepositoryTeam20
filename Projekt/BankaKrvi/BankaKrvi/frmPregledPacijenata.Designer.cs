namespace BankaKrvi
{
    partial class frmPregledPacijenata
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
            this.components = new System.ComponentModel.Container();
            this.btnAzurirajPacijenta = new System.Windows.Forms.Button();
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.btnAzurirajPacijent = new System.Windows.Forms.Button();
            this.pacijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.krvnagrupaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tippacijentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krvnagrupaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippacijentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAzurirajPacijenta
            // 
            this.btnAzurirajPacijenta.Location = new System.Drawing.Point(28, 767);
            this.btnAzurirajPacijenta.Name = "btnAzurirajPacijenta";
            this.btnAzurirajPacijenta.Size = new System.Drawing.Size(137, 23);
            this.btnAzurirajPacijenta.TabIndex = 1;
            this.btnAzurirajPacijenta.Text = "Ažuriranje pacijenta";
            this.btnAzurirajPacijenta.UseVisualStyleBackColor = true;
            this.btnAzurirajPacijenta.Click += new System.EventHandler(this.btnAzurirajPacijenta_Click);
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Location = new System.Drawing.Point(23, 22);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.Size = new System.Drawing.Size(985, 439);
            this.dgvPacijenti.TabIndex = 2;
            // 
            // btnAzurirajPacijent
            // 
            this.btnAzurirajPacijent.BackColor = System.Drawing.Color.White;
            this.btnAzurirajPacijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajPacijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajPacijent.Location = new System.Drawing.Point(23, 491);
            this.btnAzurirajPacijent.Name = "btnAzurirajPacijent";
            this.btnAzurirajPacijent.Size = new System.Drawing.Size(181, 32);
            this.btnAzurirajPacijent.TabIndex = 3;
            this.btnAzurirajPacijent.Text = "Ažuriraj pacijenta";
            this.btnAzurirajPacijent.UseVisualStyleBackColor = false;
            this.btnAzurirajPacijent.Click += new System.EventHandler(this.btnAzurirajPacijent_Click);
            this.btnAzurirajPacijent.MouseEnter += new System.EventHandler(this.btnAzurirajPacijent_MouseEnter);
            this.btnAzurirajPacijent.MouseLeave += new System.EventHandler(this.btnAzurirajPacijent_MouseLeave);
            // 
            // pacijentBindingSource
            // 
            this.pacijentBindingSource.DataSource = typeof(BankaKrvi.pacijent);
            // 
            // krvnagrupaBindingSource
            // 
            this.krvnagrupaBindingSource.DataSource = typeof(BankaKrvi.krvnagrupa);
            // 
            // tippacijentaBindingSource
            // 
            this.tippacijentaBindingSource.DataSource = typeof(BankaKrvi.tippacijenta);
            // 
            // spolBindingSource
            // 
            this.spolBindingSource.DataSource = typeof(BankaKrvi.spol);
            // 
            // frmPregledPacijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnAzurirajPacijent);
            this.Controls.Add(this.dgvPacijenti);
            this.Controls.Add(this.btnAzurirajPacijenta);
            this.Name = "frmPregledPacijenata";
            this.Text = "Pregled Pacijenata";
            this.Load += new System.EventHandler(this.frmPregledPacijenata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krvnagrupaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippacijentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAzurirajPacijenta;
        private System.Windows.Forms.BindingSource pacijentBindingSource;
        private System.Windows.Forms.BindingSource tippacijentaBindingSource;
        private System.Windows.Forms.BindingSource spolBindingSource;
        private System.Windows.Forms.BindingSource krvnagrupaBindingSource;
        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.Button btnAzurirajPacijent;
    }
}