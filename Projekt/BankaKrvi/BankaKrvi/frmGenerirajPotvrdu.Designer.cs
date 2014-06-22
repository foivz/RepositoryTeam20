namespace BankaKrvi
{
    partial class frmGenerirajPotvrdu
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
            this.dgvPregled = new System.Windows.Forms.DataGridView();
            this.btnKreiraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregled
            // 
            this.dgvPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregled.Location = new System.Drawing.Point(12, 12);
            this.dgvPregled.Name = "dgvPregled";
            this.dgvPregled.Size = new System.Drawing.Size(984, 349);
            this.dgvPregled.TabIndex = 0;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(12, 389);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(134, 23);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj potvrdu";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // frmGenerirajPotvrdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.dgvPregled);
            this.Name = "frmGenerirajPotvrdu";
            this.Text = "banka krvi | potvrda za slobodne dane";
            this.Load += new System.EventHandler(this.frmGenerirajPotvrdu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregled;
        private System.Windows.Forms.Button btnKreiraj;
    }
}