namespace BankaKrvi
{
    partial class frmPregledStanjaKrvi
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
            this.dgvZaliheKrvi = new System.Windows.Forms.DataGridView();
            this.btnPosaljiMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaliheKrvi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaliheKrvi
            // 
            this.dgvZaliheKrvi.AllowUserToAddRows = false;
            this.dgvZaliheKrvi.AllowUserToDeleteRows = false;
            this.dgvZaliheKrvi.AllowUserToOrderColumns = true;
            this.dgvZaliheKrvi.AllowUserToResizeColumns = false;
            this.dgvZaliheKrvi.AllowUserToResizeRows = false;
            this.dgvZaliheKrvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaliheKrvi.Location = new System.Drawing.Point(13, 12);
            this.dgvZaliheKrvi.MultiSelect = false;
            this.dgvZaliheKrvi.Name = "dgvZaliheKrvi";
            this.dgvZaliheKrvi.RowHeadersVisible = false;
            this.dgvZaliheKrvi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaliheKrvi.Size = new System.Drawing.Size(578, 256);
            this.dgvZaliheKrvi.TabIndex = 0;
            // 
            // btnPosaljiMail
            // 
            this.btnPosaljiMail.Location = new System.Drawing.Point(13, 274);
            this.btnPosaljiMail.Name = "btnPosaljiMail";
            this.btnPosaljiMail.Size = new System.Drawing.Size(137, 29);
            this.btnPosaljiMail.TabIndex = 1;
            this.btnPosaljiMail.Text = "Pošalji mail donatorima";
            this.btnPosaljiMail.UseVisualStyleBackColor = true;
            this.btnPosaljiMail.Click += new System.EventHandler(this.btnPosaljiMail_Click);
            // 
            // frmPregledStanjaKrvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnPosaljiMail);
            this.Controls.Add(this.dgvZaliheKrvi);
            this.Name = "frmPregledStanjaKrvi";
            this.Text = "Pregled zaliha krvi";
            this.Load += new System.EventHandler(this.frmPregledStanjaKrvi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaliheKrvi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaliheKrvi;
        private System.Windows.Forms.Button btnPosaljiMail;
    }
}