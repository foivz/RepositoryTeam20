namespace BankaKrvi
{
    partial class frmStatistikaAnalize
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
            this.cboxKategorije = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi kategoriju";
            // 
            // cboxKategorije
            // 
            this.cboxKategorije.FormattingEnabled = true;
            this.cboxKategorije.Items.AddRange(new object[] {
            "Donacije",
            "Transfuzije"});
            this.cboxKategorije.Location = new System.Drawing.Point(183, 60);
            this.cboxKategorije.Name = "cboxKategorije";
            this.cboxKategorije.Size = new System.Drawing.Size(170, 21);
            this.cboxKategorije.TabIndex = 1;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(183, 108);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(170, 23);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // frmStatistikaAnalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cboxKategorije);
            this.Controls.Add(this.label1);
            this.Name = "frmStatistikaAnalize";
            this.Text = "Banka krvi | Statistika i analize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxKategorije;
        private System.Windows.Forms.Button btnPrikazi;
    }
}