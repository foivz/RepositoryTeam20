namespace BankaKrvi
{
    partial class frmPregledPacijenata
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
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.btnAzurirajPacijenta = new System.Windows.Forms.Button();
            this.pacijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentkrvnaGrupaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijenttipPacijentaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentspolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krvnagrupaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tippacijentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transfuzijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.krvnagrupaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tippacijentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krvnagrupaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippacijentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.AllowUserToOrderColumns = true;
            this.dgvPacijenti.AutoGenerateColumns = false;
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacijentIDDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.tezinaDataGridViewTextBoxColumn,
            this.datumrodenjaDataGridViewTextBoxColumn,
            this.pacijentkrvnaGrupaIDDataGridViewTextBoxColumn,
            this.pacijenttipPacijentaIDDataGridViewTextBoxColumn,
            this.pacijentspolIDDataGridViewTextBoxColumn,
            this.donacijaDataGridViewTextBoxColumn,
            this.krvnagrupaDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn,
            this.tippacijentaDataGridViewTextBoxColumn,
            this.transfuzijaDataGridViewTextBoxColumn});
            this.dgvPacijenti.DataSource = this.pacijentBindingSource;
            this.dgvPacijenti.Location = new System.Drawing.Point(28, 40);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.Size = new System.Drawing.Size(950, 701);
            this.dgvPacijenti.TabIndex = 0;
            // 
            // btnAzurirajPacijenta
            // 
            this.btnAzurirajPacijenta.Location = new System.Drawing.Point(28, 767);
            this.btnAzurirajPacijenta.Name = "btnAzurirajPacijenta";
            this.btnAzurirajPacijenta.Size = new System.Drawing.Size(137, 23);
            this.btnAzurirajPacijenta.TabIndex = 1;
            this.btnAzurirajPacijenta.Text = "Ažuriranje pacijenta";
            this.btnAzurirajPacijenta.UseVisualStyleBackColor = true;
            this.btnAzurirajPacijenta.Click += new System.EventHandler(this.btnAzurirajPacijenta_Click);
            // 
            // pacijentIDDataGridViewTextBoxColumn
            // 
            this.pacijentIDDataGridViewTextBoxColumn.DataPropertyName = "pacijentID";
            this.pacijentIDDataGridViewTextBoxColumn.HeaderText = "pacijentID";
            this.pacijentIDDataGridViewTextBoxColumn.Name = "pacijentIDDataGridViewTextBoxColumn";
            this.pacijentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // brojPoliceOsiguranjaDataGridViewTextBoxColumn
            // 
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn.DataPropertyName = "brojPoliceOsiguranja";
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn.HeaderText = "brojPoliceOsiguranja";
            this.brojPoliceOsiguranjaDataGridViewTextBoxColumn.Name = "brojPoliceOsiguranjaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // tezinaDataGridViewTextBoxColumn
            // 
            this.tezinaDataGridViewTextBoxColumn.DataPropertyName = "tezina";
            this.tezinaDataGridViewTextBoxColumn.HeaderText = "tezina";
            this.tezinaDataGridViewTextBoxColumn.Name = "tezinaDataGridViewTextBoxColumn";
            // 
            // datumrodenjaDataGridViewTextBoxColumn
            // 
            this.datumrodenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.HeaderText = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.Name = "datumrodenjaDataGridViewTextBoxColumn";
            // 
            // pacijentkrvnaGrupaIDDataGridViewTextBoxColumn
            // 
            this.pacijentkrvnaGrupaIDDataGridViewTextBoxColumn.DataPropertyName = "pacijent_krvnaGrupaID";
            this.pacijentkrvnaGrupaIDDataGridViewTextBoxColumn.HeaderText = "pacijent_krvnaGrupaID";
            this.pacijentkrvnaGrupaIDDataGridViewTextBoxColumn.Name = "pacijentkrvnaGrupaIDDataGridViewTextBoxColumn";
            this.pacijentkrvnaGrupaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pacijenttipPacijentaIDDataGridViewTextBoxColumn
            // 
            this.pacijenttipPacijentaIDDataGridViewTextBoxColumn.DataPropertyName = "pacijent_tipPacijentaID";
            this.pacijenttipPacijentaIDDataGridViewTextBoxColumn.HeaderText = "pacijent_tipPacijentaID";
            this.pacijenttipPacijentaIDDataGridViewTextBoxColumn.Name = "pacijenttipPacijentaIDDataGridViewTextBoxColumn";
            // 
            // pacijentspolIDDataGridViewTextBoxColumn
            // 
            this.pacijentspolIDDataGridViewTextBoxColumn.DataPropertyName = "pacijent_spolID";
            this.pacijentspolIDDataGridViewTextBoxColumn.HeaderText = "pacijent_spolID";
            this.pacijentspolIDDataGridViewTextBoxColumn.Name = "pacijentspolIDDataGridViewTextBoxColumn";
            // 
            // donacijaDataGridViewTextBoxColumn
            // 
            this.donacijaDataGridViewTextBoxColumn.DataPropertyName = "donacija";
            this.donacijaDataGridViewTextBoxColumn.HeaderText = "donacija";
            this.donacijaDataGridViewTextBoxColumn.Name = "donacijaDataGridViewTextBoxColumn";
            this.donacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // krvnagrupaDataGridViewTextBoxColumn
            // 
            this.krvnagrupaDataGridViewTextBoxColumn.DataPropertyName = "krvnagrupa";
            this.krvnagrupaDataGridViewTextBoxColumn.HeaderText = "krvnagrupa";
            this.krvnagrupaDataGridViewTextBoxColumn.Name = "krvnagrupaDataGridViewTextBoxColumn";
            this.krvnagrupaDataGridViewTextBoxColumn.Visible = false;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.Visible = false;
            // 
            // tippacijentaDataGridViewTextBoxColumn
            // 
            this.tippacijentaDataGridViewTextBoxColumn.DataPropertyName = "tippacijenta";
            this.tippacijentaDataGridViewTextBoxColumn.HeaderText = "tippacijenta";
            this.tippacijentaDataGridViewTextBoxColumn.Name = "tippacijentaDataGridViewTextBoxColumn";
            this.tippacijentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // transfuzijaDataGridViewTextBoxColumn
            // 
            this.transfuzijaDataGridViewTextBoxColumn.DataPropertyName = "transfuzija";
            this.transfuzijaDataGridViewTextBoxColumn.HeaderText = "transfuzija";
            this.transfuzijaDataGridViewTextBoxColumn.Name = "transfuzijaDataGridViewTextBoxColumn";
            this.transfuzijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacijentBindingSource
            // 
            this.pacijentBindingSource.DataSource = typeof(BankaKrvi.pacijent);
            // 
            // krvnagrupaBindingSource
            // 
            this.krvnagrupaBindingSource.DataSource = typeof(BankaKrvi.krvnagrupa);
            // 
            // tippacijentaBindingSource
            // 
            this.tippacijentaBindingSource.DataSource = typeof(BankaKrvi.tippacijenta);
            // 
            // spolBindingSource
            // 
            this.spolBindingSource.DataSource = typeof(BankaKrvi.spol);
            // 
            // frmPregledPacijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 802);
            this.Controls.Add(this.btnAzurirajPacijenta);
            this.Controls.Add(this.dgvPacijenti);
            this.Name = "frmPregledPacijenata";
            this.Text = "Pregled Pacijenata";
            this.Load += new System.EventHandler(this.frmPregledPacijenata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krvnagrupaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tippacijentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.Button btnAzurirajPacijenta;
        private System.Windows.Forms.BindingSource pacijentBindingSource;
        private System.Windows.Forms.BindingSource tippacijentaBindingSource;
        private System.Windows.Forms.BindingSource spolBindingSource;
        private System.Windows.Forms.BindingSource krvnagrupaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojPoliceOsiguranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentkrvnaGrupaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijenttipPacijentaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentspolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krvnagrupaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tippacijentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transfuzijaDataGridViewTextBoxColumn;
    }
}