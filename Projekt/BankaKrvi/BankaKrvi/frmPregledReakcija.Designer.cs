﻿namespace BankaKrvi
{
    partial class frmPregledReakcija
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
            this.dgvReakcije = new System.Windows.Forms.DataGridView();
            this.btnAzurirajReakciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReakcije
            // 
            this.dgvReakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReakcije.Location = new System.Drawing.Point(26, 44);
            this.dgvReakcije.Name = "dgvReakcije";
            this.dgvReakcije.Size = new System.Drawing.Size(959, 323);
            this.dgvReakcije.TabIndex = 0;
            // 
            // btnAzurirajReakciju
            // 
            this.btnAzurirajReakciju.Location = new System.Drawing.Point(26, 467);
            this.btnAzurirajReakciju.Name = "btnAzurirajReakciju";
            this.btnAzurirajReakciju.Size = new System.Drawing.Size(146, 23);
            this.btnAzurirajReakciju.TabIndex = 1;
            this.btnAzurirajReakciju.Text = "Ažuriraj reakciju";
            this.btnAzurirajReakciju.UseVisualStyleBackColor = true;
            this.btnAzurirajReakciju.Click += new System.EventHandler(this.btnAzurirajReakciju_Click);
            // 
            // frmPregledReakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnAzurirajReakciju);
            this.Controls.Add(this.dgvReakcije);
            this.Name = "frmPregledReakcija";
            this.Text = "Banka krvi | Pregled reakcija";
            this.Load += new System.EventHandler(this.frmPregledReakcija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReakcije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReakcije;
        private System.Windows.Forms.Button btnAzurirajReakciju;
    }
}