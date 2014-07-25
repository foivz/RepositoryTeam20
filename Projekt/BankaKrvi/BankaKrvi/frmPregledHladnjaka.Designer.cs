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
            this.dgvHladnjaci.BackgroundColor = System.Drawing.Color.White;
            this.dgvHladnjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHladnjaci.Location = new System.Drawing.Point(234, 46);
            this.dgvHladnjaci.MultiSelect = false;
            this.dgvHladnjaci.Name = "dgvHladnjaci";
            this.dgvHladnjaci.RowHeadersVisible = false;
            this.dgvHladnjaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHladnjaci.Size = new System.Drawing.Size(573, 246);
            this.dgvHladnjaci.TabIndex = 0;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.White;
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriraj.Location = new System.Drawing.Point(234, 308);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(190, 34);
            this.btnAzuriraj.TabIndex = 1;
            this.btnAzuriraj.Text = "Ažuriraj hladnjak";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            this.btnAzuriraj.MouseEnter += new System.EventHandler(this.btnAzuriraj_MouseEnter);
            this.btnAzuriraj.MouseLeave += new System.EventHandler(this.btnAzuriraj_MouseLeave);
            // 
            // btnTemperaturaHladnjaka
            // 
            this.btnTemperaturaHladnjaka.BackColor = System.Drawing.Color.White;
            this.btnTemperaturaHladnjaka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemperaturaHladnjaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTemperaturaHladnjaka.Location = new System.Drawing.Point(549, 308);
            this.btnTemperaturaHladnjaka.Name = "btnTemperaturaHladnjaka";
            this.btnTemperaturaHladnjaka.Size = new System.Drawing.Size(190, 34);
            this.btnTemperaturaHladnjaka.TabIndex = 2;
            this.btnTemperaturaHladnjaka.Text = "Temperatura hladnjaka";
            this.btnTemperaturaHladnjaka.UseVisualStyleBackColor = false;
            this.btnTemperaturaHladnjaka.Click += new System.EventHandler(this.btnTemperaturaHladnjaka_Click);
            this.btnTemperaturaHladnjaka.MouseEnter += new System.EventHandler(this.btnTemperaturaHladnjaka_MouseEnter);
            this.btnTemperaturaHladnjaka.MouseLeave += new System.EventHandler(this.btnTemperaturaHladnjaka_MouseLeave);
            // 
            // frmPregledHladnjaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 442);
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