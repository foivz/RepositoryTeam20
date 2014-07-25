namespace BankaKrvi
{
    partial class frmPregledUstanova
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
            this.dgvUstanove = new System.Windows.Forms.DataGridView();
            this.btnAzurirajUStanovu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUstanove)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUstanove
            // 
            this.dgvUstanove.BackgroundColor = System.Drawing.Color.White;
            this.dgvUstanove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUstanove.Location = new System.Drawing.Point(33, 28);
            this.dgvUstanove.Name = "dgvUstanove";
            this.dgvUstanove.Size = new System.Drawing.Size(944, 338);
            this.dgvUstanove.TabIndex = 0;
            // 
            // btnAzurirajUStanovu
            // 
            this.btnAzurirajUStanovu.BackColor = System.Drawing.Color.White;
            this.btnAzurirajUStanovu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajUStanovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajUStanovu.Location = new System.Drawing.Point(33, 412);
            this.btnAzurirajUStanovu.Name = "btnAzurirajUStanovu";
            this.btnAzurirajUStanovu.Size = new System.Drawing.Size(161, 36);
            this.btnAzurirajUStanovu.TabIndex = 1;
            this.btnAzurirajUStanovu.Text = "Ažuriraj ustanovu";
            this.btnAzurirajUStanovu.UseVisualStyleBackColor = false;
            this.btnAzurirajUStanovu.Click += new System.EventHandler(this.btnAzurirajUStanovu_Click);
            this.btnAzurirajUStanovu.MouseEnter += new System.EventHandler(this.btnAzurirajUStanovu_MouseEnter);
            this.btnAzurirajUStanovu.MouseLeave += new System.EventHandler(this.btnAzurirajUStanovu_MouseLeave);
            // 
            // frmPregledUstanova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnAzurirajUStanovu);
            this.Controls.Add(this.dgvUstanove);
            this.Name = "frmPregledUstanova";
            this.Text = "Banka krvi | Pregled ustanova";
            this.Load += new System.EventHandler(this.frmPregledUstanova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUstanove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUstanove;
        private System.Windows.Forms.Button btnAzurirajUStanovu;
    }
}