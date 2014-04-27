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
            this.dgvDonacije = new System.Windows.Forms.DataGridView();
            this.dgvReakcije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfuzije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransfuzije
            // 
            this.dgvTransfuzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfuzije.Location = new System.Drawing.Point(22, 40);
            this.dgvTransfuzije.Name = "dgvTransfuzije";
            this.dgvTransfuzije.Size = new System.Drawing.Size(481, 245);
            this.dgvTransfuzije.TabIndex = 0;
            // 
            // dgvDonacije
            // 
            this.dgvDonacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonacije.Location = new System.Drawing.Point(581, 40);
            this.dgvDonacije.Name = "dgvDonacije";
            this.dgvDonacije.Size = new System.Drawing.Size(386, 160);
            this.dgvDonacije.TabIndex = 1;
            // 
            // dgvReakcije
            // 
            this.dgvReakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReakcije.Location = new System.Drawing.Point(581, 278);
            this.dgvReakcije.Name = "dgvReakcije";
            this.dgvReakcije.Size = new System.Drawing.Size(386, 160);
            this.dgvReakcije.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transfuzije:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Donacije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reakcije:";
            // 
            // frmPregledTransfuzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReakcije);
            this.Controls.Add(this.dgvDonacije);
            this.Controls.Add(this.dgvTransfuzije);
            this.Name = "frmPregledTransfuzija";
            this.Text = "Pregled  transfuzija";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfuzije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReakcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransfuzije;
        private System.Windows.Forms.DataGridView dgvDonacije;
        private System.Windows.Forms.DataGridView dgvReakcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}