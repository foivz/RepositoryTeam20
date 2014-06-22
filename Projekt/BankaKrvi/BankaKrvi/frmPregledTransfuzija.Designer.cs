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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfuzije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransfuzije
            // 
            this.dgvTransfuzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfuzije.Location = new System.Drawing.Point(12, 24);
            this.dgvTransfuzije.Name = "dgvTransfuzije";
            this.dgvTransfuzije.Size = new System.Drawing.Size(955, 492);
            this.dgvTransfuzije.TabIndex = 3;
            // 
            // btnAzurirajTransfuzije
            // 
            this.btnAzurirajTransfuzije.Location = new System.Drawing.Point(12, 543);
            this.btnAzurirajTransfuzije.Name = "btnAzurirajTransfuzije";
            this.btnAzurirajTransfuzije.Size = new System.Drawing.Size(101, 23);
            this.btnAzurirajTransfuzije.TabIndex = 4;
            this.btnAzurirajTransfuzije.Text = "Ažuriraj transfuzije";
            this.btnAzurirajTransfuzije.UseVisualStyleBackColor = true;
            this.btnAzurirajTransfuzije.Click += new System.EventHandler(this.btnAzurirajTransfuzije_Click);
            // 
            // frmPregledTransfuzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnAzurirajTransfuzije);
            this.Controls.Add(this.dgvTransfuzije);
            this.Name = "frmPregledTransfuzija";
            this.Text = "frmPregledTransfuzija";
            this.Load += new System.EventHandler(this.frmPregledTransfuzija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfuzije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransfuzije;
        private System.Windows.Forms.Button btnAzurirajTransfuzije;
    }
}