﻿namespace BankaKrvi
{
    partial class frmStatistikaDonacije
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
            this.dgvStatistikaDonacija = new System.Windows.Forms.DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistikaDonacija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatistikaDonacija
            // 
            this.dgvStatistikaDonacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistikaDonacija.Location = new System.Drawing.Point(21, 24);
            this.dgvStatistikaDonacija.Name = "dgvStatistikaDonacija";
            this.dgvStatistikaDonacija.Size = new System.Drawing.Size(963, 271);
            this.dgvStatistikaDonacija.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(21, 311);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(600, 300);
            this.webBrowser1.TabIndex = 1;
            // 
            // frmStatistikaDonacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.dgvStatistikaDonacija);
            this.Name = "frmStatistikaDonacije";
            this.Text = "Statistika donacija";
            this.Load += new System.EventHandler(this.frmStatistikaDonacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistikaDonacija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatistikaDonacija;
        private System.Windows.Forms.WebBrowser webBrowser1;
        //private System.Windows.Forms.BindingSource statistikaDonacijeDataSetBindingSource;
        //private statistikaDonacijeDataSet statistikaDonacijeDataSet;
        //private System.Windows.Forms.BindingSource statistikadonacijeBindingSource;
        //private statistikaDonacijeDataSetTableAdapters.statistikadonacijeTableAdapter statistikadonacijeTableAdapter;
    }
}