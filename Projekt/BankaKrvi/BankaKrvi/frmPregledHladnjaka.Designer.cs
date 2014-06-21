namespace BankaKrvi
{
    partial class frmPregledHladnjaka
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
            this.dgvHladnjaci = new System.Windows.Forms.DataGridView();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnTemperaturaHladnjaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHladnjaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHladnjaci
            // 
            this.dgvHladnjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHladnjaci.Location = new System.Drawing.Point(21, 28);
            this.dgvHladnjaci.MultiSelect = false;
            this.dgvHladnjaci.Name = "dgvHladnjaci";
            this.dgvHladnjaci.RowHeadersVisible = false;
            this.dgvHladnjaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHladnjaci.Size = new System.Drawing.Size(573, 246);
            this.dgvHladnjaci.TabIndex = 0;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(21, 298);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(112, 23);
            this.btnAzuriraj.TabIndex = 1;
            this.btnAzuriraj.Text = "Ažuriraj hladnjak";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnTemperaturaHladnjaka
            // 
            this.btnTemperaturaHladnjaka.Location = new System.Drawing.Point(149, 298);
            this.btnTemperaturaHladnjaka.Name = "btnTemperaturaHladnjaka";
            this.btnTemperaturaHladnjaka.Size = new System.Drawing.Size(133, 23);
            this.btnTemperaturaHladnjaka.TabIndex = 2;
            this.btnTemperaturaHladnjaka.Text = "Temperatura hladnjaka";
            this.btnTemperaturaHladnjaka.UseVisualStyleBackColor = true;
            this.btnTemperaturaHladnjaka.Click += new System.EventHandler(this.btnTemperaturaHladnjaka_Click);
            // 
            // frmPregledHladnjaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnTemperaturaHladnjaka);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.dgvHladnjaci);
            this.Name = "frmPregledHladnjaka";
            this.Text = "Pregled hladnjaka";
            this.Load += new System.EventHandler(this.frmPregledHladnjaka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHladnjaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHladnjaci;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnTemperaturaHladnjaka;
    }
}