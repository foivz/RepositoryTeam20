namespace BankaKrvi
{
    partial class frmPrijavaKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijavaKorisnika));
            this.txtPrkKorIme = new System.Windows.Forms.TextBox();
            this.txtPrkLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrkPrijavi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrkKorIme
            // 
            this.txtPrkKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrkKorIme.Location = new System.Drawing.Point(103, 35);
            this.txtPrkKorIme.Multiline = true;
            this.txtPrkKorIme.Name = "txtPrkKorIme";
            this.txtPrkKorIme.Size = new System.Drawing.Size(127, 20);
            this.txtPrkKorIme.TabIndex = 0;
            this.txtPrkKorIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrkKorIme.MouseEnter += new System.EventHandler(this.txtPrkKorIme_MouseEnter);
            this.txtPrkKorIme.MouseLeave += new System.EventHandler(this.txtPrkKorIme_MouseLeave);
            // 
            // txtPrkLozinka
            // 
            this.txtPrkLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrkLozinka.Location = new System.Drawing.Point(103, 69);
            this.txtPrkLozinka.Multiline = true;
            this.txtPrkLozinka.Name = "txtPrkLozinka";
            this.txtPrkLozinka.PasswordChar = '*';
            this.txtPrkLozinka.Size = new System.Drawing.Size(127, 20);
            this.txtPrkLozinka.TabIndex = 1;
            this.txtPrkLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrkLozinka.MouseEnter += new System.EventHandler(this.txtPrkLozinka_MouseEnter);
            this.txtPrkLozinka.MouseLeave += new System.EventHandler(this.txtPrkLozinka_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // btnPrkPrijavi
            // 
            this.btnPrkPrijavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrkPrijavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrkPrijavi.Location = new System.Drawing.Point(38, 112);
            this.btnPrkPrijavi.Name = "btnPrkPrijavi";
            this.btnPrkPrijavi.Size = new System.Drawing.Size(180, 30);
            this.btnPrkPrijavi.TabIndex = 4;
            this.btnPrkPrijavi.Text = "Prijavi se";
            this.btnPrkPrijavi.UseVisualStyleBackColor = true;
            this.btnPrkPrijavi.Click += new System.EventHandler(this.btnPrkPrijavi_Click);
            this.btnPrkPrijavi.MouseEnter += new System.EventHandler(this.btnPrkPrijavi_MouseEnter);
            this.btnPrkPrijavi.MouseLeave += new System.EventHandler(this.btnPrkPrijavi_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 108);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrkPrijavi);
            this.groupBox1.Controls.Add(this.txtPrkKorIme);
            this.groupBox1.Controls.Add(this.txtPrkLozinka);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(93, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prijava korisnika: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 100);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmPrijavaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 299);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrijavaKorisnika";
            this.Text = "Banka Krvi | Prijava korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrkKorIme;
        private System.Windows.Forms.TextBox txtPrkLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrkPrijavi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}