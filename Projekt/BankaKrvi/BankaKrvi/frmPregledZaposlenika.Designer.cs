namespace BankaKrvi
{
    partial class frmPregledZaposlenika
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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnAzurirajZaposlenika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(24, 47);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.Size = new System.Drawing.Size(954, 546);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // btnAzurirajZaposlenika
            // 
            this.btnAzurirajZaposlenika.Location = new System.Drawing.Point(24, 614);
            this.btnAzurirajZaposlenika.Name = "btnAzurirajZaposlenika";
            this.btnAzurirajZaposlenika.Size = new System.Drawing.Size(135, 23);
            this.btnAzurirajZaposlenika.TabIndex = 1;
            this.btnAzurirajZaposlenika.Text = "Ažuriraj zaposlenika";
            this.btnAzurirajZaposlenika.UseVisualStyleBackColor = true;
            // 
            // frmPregledZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnAzurirajZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "frmPregledZaposlenika";
            this.Text = "Banka krvi | Pregled zaposlenika";
            this.Load += new System.EventHandler(this.frmPregledZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnAzurirajZaposlenika;
    }
}