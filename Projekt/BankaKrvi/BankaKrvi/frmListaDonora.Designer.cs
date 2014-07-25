namespace BankaKrvi
{
    partial class frmListaDonora
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listadonoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaDonoraDataset = new BankaKrvi.ListaDonoraDataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listadonoraTableAdapter = new BankaKrvi.ListaDonoraDatasetTableAdapters.listadonoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listadonoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDonoraDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // listadonoraBindingSource
            // 
            this.listadonoraBindingSource.DataMember = "listadonora";
            this.listadonoraBindingSource.DataSource = this.ListaDonoraDataset;
            // 
            // ListaDonoraDataset
            // 
            this.ListaDonoraDataset.DataSetName = "ListaDonoraDataset";
            this.ListaDonoraDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listadonoraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BankaKrvi.ListaDonoraReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(34, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(946, 536);
            this.reportViewer1.TabIndex = 0;
            // 
            // listadonoraTableAdapter
            // 
            this.listadonoraTableAdapter.ClearBeforeFill = true;
            // 
            // frmListaDonora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListaDonora";
            this.Text = "Lista donora";
            this.Load += new System.EventHandler(this.frmListaDonora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadonoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDonoraDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listadonoraBindingSource;
        private ListaDonoraDataset ListaDonoraDataset;
        private ListaDonoraDatasetTableAdapters.listadonoraTableAdapter listadonoraTableAdapter;
    }
}