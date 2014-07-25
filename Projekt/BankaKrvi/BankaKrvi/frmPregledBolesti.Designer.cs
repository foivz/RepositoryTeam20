namespace BankaKrvi
{
    partial class frmPregledBolesti
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
            this.dgvBolesti = new System.Windows.Forms.DataGridView();
            this.btnAzurirajBolest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolesti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBolesti
            // 
            this.dgvBolesti.BackgroundColor = System.Drawing.Color.White;
            this.dgvBolesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolesti.Location = new System.Drawing.Point(25, 52);
            this.dgvBolesti.Name = "dgvBolesti";
            this.dgvBolesti.Size = new System.Drawing.Size(965, 243);
            this.dgvBolesti.TabIndex = 0;
            // 
            // btnAzurirajBolest
            // 
            this.btnAzurirajBolest.BackColor = System.Drawing.Color.White;
            this.btnAzurirajBolest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajBolest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajBolest.Location = new System.Drawing.Point(25, 335);
            this.btnAzurirajBolest.Name = "btnAzurirajBolest";
            this.btnAzurirajBolest.Size = new System.Drawing.Size(164, 34);
            this.btnAzurirajBolest.TabIndex = 1;
            this.btnAzurirajBolest.Text = "Ažuriraj bolest";
            this.btnAzurirajBolest.UseVisualStyleBackColor = false;
            this.btnAzurirajBolest.Click += new System.EventHandler(this.btnAzurirajBolest_Click);
            this.btnAzurirajBolest.MouseEnter += new System.EventHandler(this.btnAzurirajBolest_MouseEnter);
            this.btnAzurirajBolest.MouseLeave += new System.EventHandler(this.btnAzurirajBolest_MouseLeave);
            // 
            // frmPregledBolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnAzurirajBolest);
            this.Controls.Add(this.dgvBolesti);
            this.Name = "frmPregledBolesti";
            this.Text = "Banka krvi |Pregled bolesti";
            this.Load += new System.EventHandler(this.frmPregledBolesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolesti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBolesti;
        private System.Windows.Forms.Button btnAzurirajBolest;
    }
}