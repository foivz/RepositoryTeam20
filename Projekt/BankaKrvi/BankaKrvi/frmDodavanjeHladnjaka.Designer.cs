namespace BankaKrvi
{
    partial class frmDodavanjeHladnjaka
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbPun = new System.Windows.Forms.CheckBox();
            this.cboxKrvnaGrupa = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Krvna grupa";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(111, 58);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 5;
            // 
            // cbPun
            // 
            this.cbPun.AutoSize = true;
            this.cbPun.Location = new System.Drawing.Point(111, 87);
            this.cbPun.Name = "cbPun";
            this.cbPun.Size = new System.Drawing.Size(15, 14);
            this.cbPun.TabIndex = 2;
            this.cbPun.UseVisualStyleBackColor = true;
            // 
            // cboxKrvnaGrupa
            // 
            this.cboxKrvnaGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxKrvnaGrupa.FormattingEnabled = true;
            this.cboxKrvnaGrupa.Location = new System.Drawing.Point(111, 110);
            this.cboxKrvnaGrupa.Name = "cboxKrvnaGrupa";
            this.cboxKrvnaGrupa.Size = new System.Drawing.Size(121, 21);
            this.cboxKrvnaGrupa.TabIndex = 3;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(111, 163);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(121, 23);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmDodavanjeHladnjaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cboxKrvnaGrupa);
            this.Controls.Add(this.cbPun);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodavanjeHladnjaka";
            this.Text = "Dodavanje hladnjaka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox cbPun;
        private System.Windows.Forms.ComboBox cboxKrvnaGrupa;
        private System.Windows.Forms.Button btnSpremi;
    }
}