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
            this.dgvZaliheKrvi.BackgroundColor = System.Drawing.Color.White;
            this.dgvZaliheKrvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaliheKrvi.Location = new System.Drawing.Point(306, 125);
            this.dgvZaliheKrvi.MultiSelect = false;
            this.dgvZaliheKrvi.Name = "dgvZaliheKrvi";
            this.dgvZaliheKrvi.RowHeadersVisible = false;
            this.dgvZaliheKrvi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaliheKrvi.Size = new System.Drawing.Size(578, 256);
            this.dgvZaliheKrvi.TabIndex = 0;
            // 
            // btnPosaljiMail
            // 
            this.btnPosaljiMail.BackColor = System.Drawing.Color.White;
            this.btnPosaljiMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosaljiMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosaljiMail.Location = new System.Drawing.Point(306, 404);
            this.btnPosaljiMail.Name = "btnPosaljiMail";
            this.btnPosaljiMail.Size = new System.Drawing.Size(137, 29);
            this.btnPosaljiMail.TabIndex = 1;
            this.btnPosaljiMail.Text = "Pošalji mail donatorima";
            this.btnPosaljiMail.UseVisualStyleBackColor = false;
            this.btnPosaljiMail.Click += new System.EventHandler(this.btnPosaljiMail_Click);
            this.btnPosaljiMail.MouseEnter += new System.EventHandler(this.btnPosaljiMail_MouseEnter);
            this.btnPosaljiMail.MouseLeave += new System.EventHandler(this.btnPosaljiMail_MouseLeave);
            // 
            // frmPregledStanjaKrvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 662);
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