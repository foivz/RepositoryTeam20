namespace BankaKrvi
{
    partial class frmHladnjak
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
            this.imgTemperatura = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajDoze = new System.Windows.Forms.Button();
            this.btnIzvadiDoze = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTemperatura
            // 
            this.imgTemperatura.Location = new System.Drawing.Point(353, 77);
            this.imgTemperatura.Name = "imgTemperatura";
            this.imgTemperatura.Size = new System.Drawing.Size(248, 172);
            this.imgTemperatura.TabIndex = 0;
            this.imgTemperatura.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura hladnjaka:";
            // 
            // btnDodajDoze
            // 
            this.btnDodajDoze.Location = new System.Drawing.Point(48, 131);
            this.btnDodajDoze.Name = "btnDodajDoze";
            this.btnDodajDoze.Size = new System.Drawing.Size(114, 23);
            this.btnDodajDoze.TabIndex = 2;
            this.btnDodajDoze.Text = "Dodaj doze";
            this.btnDodajDoze.UseVisualStyleBackColor = true;
            this.btnDodajDoze.Click += new System.EventHandler(this.btnDodajDoze_Click);
            // 
            // btnIzvadiDoze
            // 
            this.btnIzvadiDoze.Location = new System.Drawing.Point(48, 177);
            this.btnIzvadiDoze.Name = "btnIzvadiDoze";
            this.btnIzvadiDoze.Size = new System.Drawing.Size(114, 23);
            this.btnIzvadiDoze.TabIndex = 3;
            this.btnIzvadiDoze.Text = "Izvadi doze";
            this.btnIzvadiDoze.UseVisualStyleBackColor = true;
            // 
            // frmHladnjak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnIzvadiDoze);
            this.Controls.Add(this.btnDodajDoze);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgTemperatura);
            this.Name = "frmHladnjak";
            this.Text = "Hladnjak";
            ((System.ComponentModel.ISupportInitialize)(this.imgTemperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajDoze;
        private System.Windows.Forms.Button btnIzvadiDoze;
    }
}