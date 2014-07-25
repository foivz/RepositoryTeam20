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
            this.dgvZaposlenici.BackgroundColor = System.Drawing.Color.White;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(24, 12);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.Size = new System.Drawing.Size(954, 334);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // btnAzurirajZaposlenika
            // 
            this.btnAzurirajZaposlenika.BackColor = System.Drawing.Color.White;
            this.btnAzurirajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajZaposlenika.Location = new System.Drawing.Point(24, 382);
            this.btnAzurirajZaposlenika.Name = "btnAzurirajZaposlenika";
            this.btnAzurirajZaposlenika.Size = new System.Drawing.Size(184, 38);
            this.btnAzurirajZaposlenika.TabIndex = 1;
            this.btnAzurirajZaposlenika.Text = "Ažuriraj zaposlenika";
            this.btnAzurirajZaposlenika.UseVisualStyleBackColor = false;
            this.btnAzurirajZaposlenika.Click += new System.EventHandler(this.btnAzurirajZaposlenika_Click);
            this.btnAzurirajZaposlenika.MouseEnter += new System.EventHandler(this.btnAzurirajZaposlenika_MouseEnter);
            this.btnAzurirajZaposlenika.MouseLeave += new System.EventHandler(this.btnAzurirajZaposlenika_MouseLeave);
            // 
            // frmPregledZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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