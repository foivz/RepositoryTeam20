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
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.btnAzurirajPacijenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Location = new System.Drawing.Point(28, 36);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.Size = new System.Drawing.Size(561, 252);
            this.dgvPacijenti.TabIndex = 0;
            // 
            // btnAzurirajPacijenta
            // 
            this.btnAzurirajPacijenta.Location = new System.Drawing.Point(28, 318);
            this.btnAzurirajPacijenta.Name = "btnAzurirajPacijenta";
            this.btnAzurirajPacijenta.Size = new System.Drawing.Size(137, 23);
            this.btnAzurirajPacijenta.TabIndex = 1;
            this.btnAzurirajPacijenta.Text = "Ažuriranje pacijenta";
            this.btnAzurirajPacijenta.UseVisualStyleBackColor = true;
            this.btnAzurirajPacijenta.Click += new System.EventHandler(this.btnAzurirajPacijenta_Click);
            // 
            // frmPregledPacijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnAzurirajPacijenta);
            this.Controls.Add(this.dgvPacijenti);
            this.Name = "frmPregledPacijenata";
            this.Text = "Pregled Pacijenata";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.Button btnAzurirajPacijenta;
    }
}