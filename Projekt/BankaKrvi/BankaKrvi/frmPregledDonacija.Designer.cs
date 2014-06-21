namespace BankaKrvi
{
    partial class frmPregledDonacija
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
            this.dgvDonacije = new System.Windows.Forms.DataGridView();
            this.btnDodajTest = new System.Windows.Forms.Button();
            this.dgvTestovi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAzurirajTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonacije
            // 
            this.dgvDonacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonacije.Location = new System.Drawing.Point(12, 26);
            this.dgvDonacije.Name = "dgvDonacije";
            this.dgvDonacije.Size = new System.Drawing.Size(984, 247);
            this.dgvDonacije.TabIndex = 0;
            this.dgvDonacije.SelectionChanged += new System.EventHandler(this.dgvDonacije_SelectionChanged);
            // 
            // btnDodajTest
            // 
            this.btnDodajTest.Location = new System.Drawing.Point(23, 558);
            this.btnDodajTest.Name = "btnDodajTest";
            this.btnDodajTest.Size = new System.Drawing.Size(112, 23);
            this.btnDodajTest.TabIndex = 1;
            this.btnDodajTest.Text = "Dodaj test";
            this.btnDodajTest.UseVisualStyleBackColor = true;
            this.btnDodajTest.Click += new System.EventHandler(this.btnDodajTest_Click);
            // 
            // dgvTestovi
            // 
            this.dgvTestovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestovi.Location = new System.Drawing.Point(16, 344);
            this.dgvTestovi.Name = "dgvTestovi";
            this.dgvTestovi.Size = new System.Drawing.Size(980, 160);
            this.dgvTestovi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Donacije:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Testovi:";
            // 
            // btnAzurirajTest
            // 
            this.btnAzurirajTest.Location = new System.Drawing.Point(186, 558);
            this.btnAzurirajTest.Name = "btnAzurirajTest";
            this.btnAzurirajTest.Size = new System.Drawing.Size(119, 23);
            this.btnAzurirajTest.TabIndex = 5;
            this.btnAzurirajTest.Text = "Ažuriraj test";
            this.btnAzurirajTest.UseVisualStyleBackColor = true;
            this.btnAzurirajTest.Click += new System.EventHandler(this.btnAzurirajTest_Click);
            // 
            // frmPregledDonacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 644);
            this.Controls.Add(this.btnAzurirajTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTestovi);
            this.Controls.Add(this.btnDodajTest);
            this.Controls.Add(this.dgvDonacije);
            this.Name = "frmPregledDonacija";
            this.Text = "Pregled donacija";
            this.Load += new System.EventHandler(this.frmPregledDonacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonacije;
        private System.Windows.Forms.Button btnDodajTest;
        private System.Windows.Forms.DataGridView dgvTestovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAzurirajTest;
    }
}