﻿namespace BankaKrvi
{
    partial class frmBankaKrvi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPacijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeNovogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generiranjeListeDonoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potvrdaZaSlobodneDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledDonacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeDonacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transfuzijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledTransfuzijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeTransfuzijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.praćenjeStanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledStanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledHladnjakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajHladnjakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustanoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledUstanovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUstanovuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledBolestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajBolestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reakcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledReakcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajReakcijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msOtvoriZatvoriHladnjak = new System.Windows.Forms.ToolStripMenuItem();
            this.mjeracTemperature = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLogiraniKorisnik = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLogiraniUloga = new System.Windows.Forms.ToolStripStatusLabel();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentiToolStripMenuItem,
            this.donacijeToolStripMenuItem,
            this.transfuzijeToolStripMenuItem,
            this.praćenjeStanjaToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.msOtvoriZatvoriHladnjak,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacijentiToolStripMenuItem
            // 
            this.pacijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledPacijenataToolStripMenuItem,
            this.dodavanjeNovogToolStripMenuItem,
            this.generiranjeListeDonoraToolStripMenuItem,
            this.potvrdaZaSlobodneDaneToolStripMenuItem});
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            // 
            // pregledPacijenataToolStripMenuItem
            // 
            this.pregledPacijenataToolStripMenuItem.Name = "pregledPacijenataToolStripMenuItem";
            this.pregledPacijenataToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pregledPacijenataToolStripMenuItem.Text = "Pregled pacijenata";
            this.pregledPacijenataToolStripMenuItem.Click += new System.EventHandler(this.pregledPacijenataToolStripMenuItem_Click);
            // 
            // dodavanjeNovogToolStripMenuItem
            // 
            this.dodavanjeNovogToolStripMenuItem.Name = "dodavanjeNovogToolStripMenuItem";
            this.dodavanjeNovogToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dodavanjeNovogToolStripMenuItem.Text = "Dodavanje novog";
            this.dodavanjeNovogToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeNovogToolStripMenuItem_Click);
            // 
            // generiranjeListeDonoraToolStripMenuItem
            // 
            this.generiranjeListeDonoraToolStripMenuItem.Name = "generiranjeListeDonoraToolStripMenuItem";
            this.generiranjeListeDonoraToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.generiranjeListeDonoraToolStripMenuItem.Text = "Generiranje liste donora";
            this.generiranjeListeDonoraToolStripMenuItem.Click += new System.EventHandler(this.generiranjeListeDonoraToolStripMenuItem_Click);
            // 
            // potvrdaZaSlobodneDaneToolStripMenuItem
            // 
            this.potvrdaZaSlobodneDaneToolStripMenuItem.Name = "potvrdaZaSlobodneDaneToolStripMenuItem";
            this.potvrdaZaSlobodneDaneToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.potvrdaZaSlobodneDaneToolStripMenuItem.Text = "Potvrda za slobodne dane";
            this.potvrdaZaSlobodneDaneToolStripMenuItem.Click += new System.EventHandler(this.potvrdaZaSlobodneDaneToolStripMenuItem_Click);
            // 
            // donacijeToolStripMenuItem
            // 
            this.donacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledDonacijaToolStripMenuItem,
            this.dodavanjeDonacijeToolStripMenuItem});
            this.donacijeToolStripMenuItem.Name = "donacijeToolStripMenuItem";
            this.donacijeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.donacijeToolStripMenuItem.Text = "Donacije";
            // 
            // pregledDonacijaToolStripMenuItem
            // 
            this.pregledDonacijaToolStripMenuItem.Name = "pregledDonacijaToolStripMenuItem";
            this.pregledDonacijaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pregledDonacijaToolStripMenuItem.Text = "Pregled donacija";
            this.pregledDonacijaToolStripMenuItem.Click += new System.EventHandler(this.pregledDonacijaToolStripMenuItem_Click);
            // 
            // dodavanjeDonacijeToolStripMenuItem
            // 
            this.dodavanjeDonacijeToolStripMenuItem.Name = "dodavanjeDonacijeToolStripMenuItem";
            this.dodavanjeDonacijeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dodavanjeDonacijeToolStripMenuItem.Text = "Dodavanje donacije";
            this.dodavanjeDonacijeToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeDonacijeToolStripMenuItem_Click);
            // 
            // transfuzijeToolStripMenuItem
            // 
            this.transfuzijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledTransfuzijaToolStripMenuItem,
            this.dodavanjeTransfuzijeToolStripMenuItem});
            this.transfuzijeToolStripMenuItem.Name = "transfuzijeToolStripMenuItem";
            this.transfuzijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.transfuzijeToolStripMenuItem.Text = "Transfuzije";
            // 
            // pregledTransfuzijaToolStripMenuItem
            // 
            this.pregledTransfuzijaToolStripMenuItem.Name = "pregledTransfuzijaToolStripMenuItem";
            this.pregledTransfuzijaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledTransfuzijaToolStripMenuItem.Text = "Pregled transfuzija";
            this.pregledTransfuzijaToolStripMenuItem.Click += new System.EventHandler(this.pregledTransfuzijaToolStripMenuItem_Click);
            // 
            // dodavanjeTransfuzijeToolStripMenuItem
            // 
            this.dodavanjeTransfuzijeToolStripMenuItem.Name = "dodavanjeTransfuzijeToolStripMenuItem";
            this.dodavanjeTransfuzijeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodavanjeTransfuzijeToolStripMenuItem.Text = "Dodavanje transfuzije";
            this.dodavanjeTransfuzijeToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeTransfuzijeToolStripMenuItem_Click);
            // 
            // praćenjeStanjaToolStripMenuItem
            // 
            this.praćenjeStanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledStanjaToolStripMenuItem,
            this.pregledHladnjakaToolStripMenuItem,
            this.dodajHladnjakToolStripMenuItem});
            this.praćenjeStanjaToolStripMenuItem.Name = "praćenjeStanjaToolStripMenuItem";
            this.praćenjeStanjaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.praćenjeStanjaToolStripMenuItem.Text = "Hladnjaci";
            this.praćenjeStanjaToolStripMenuItem.Click += new System.EventHandler(this.praćenjeStanjaToolStripMenuItem_Click);
            // 
            // pregledStanjaToolStripMenuItem
            // 
            this.pregledStanjaToolStripMenuItem.Name = "pregledStanjaToolStripMenuItem";
            this.pregledStanjaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pregledStanjaToolStripMenuItem.Text = "Pregled zaliha krvi";
            this.pregledStanjaToolStripMenuItem.Click += new System.EventHandler(this.pregledStanjaToolStripMenuItem_Click);
            // 
            // pregledHladnjakaToolStripMenuItem
            // 
            this.pregledHladnjakaToolStripMenuItem.Name = "pregledHladnjakaToolStripMenuItem";
            this.pregledHladnjakaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pregledHladnjakaToolStripMenuItem.Text = "Pregled hladnjaka";
            this.pregledHladnjakaToolStripMenuItem.Click += new System.EventHandler(this.pregledHladnjakaToolStripMenuItem_Click);
            // 
            // dodajHladnjakToolStripMenuItem
            // 
            this.dodajHladnjakToolStripMenuItem.Name = "dodajHladnjakToolStripMenuItem";
            this.dodajHladnjakToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dodajHladnjakToolStripMenuItem.Text = "Dodaj hladnjak";
            this.dodajHladnjakToolStripMenuItem.Click += new System.EventHandler(this.dodajHladnjakToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem});
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.statistikaToolStripMenuItem.Text = "Statistika i analize";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniciToolStripMenuItem,
            this.ustanoveToolStripMenuItem,
            this.bolestiToolStripMenuItem,
            this.reakcijeToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.adminToolStripMenuItem.Text = "Administracija sustava";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledZaposlenikaToolStripMenuItem,
            this.dodajZaposlenikaToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // pregledZaposlenikaToolStripMenuItem
            // 
            this.pregledZaposlenikaToolStripMenuItem.Name = "pregledZaposlenikaToolStripMenuItem";
            this.pregledZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pregledZaposlenikaToolStripMenuItem.Text = "Pregled zaposlenika";
            this.pregledZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.pregledZaposlenikaToolStripMenuItem_Click);
            // 
            // dodajZaposlenikaToolStripMenuItem
            // 
            this.dodajZaposlenikaToolStripMenuItem.Name = "dodajZaposlenikaToolStripMenuItem";
            this.dodajZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dodajZaposlenikaToolStripMenuItem.Text = "Dodaj zaposlenika";
            this.dodajZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.dodajZaposlenikaToolStripMenuItem_Click);
            // 
            // ustanoveToolStripMenuItem
            // 
            this.ustanoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledUstanovaToolStripMenuItem,
            this.dodajUstanovuToolStripMenuItem});
            this.ustanoveToolStripMenuItem.Name = "ustanoveToolStripMenuItem";
            this.ustanoveToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ustanoveToolStripMenuItem.Text = "Ustanove";
            // 
            // pregledUstanovaToolStripMenuItem
            // 
            this.pregledUstanovaToolStripMenuItem.Name = "pregledUstanovaToolStripMenuItem";
            this.pregledUstanovaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pregledUstanovaToolStripMenuItem.Text = "Pregled ustanova";
            this.pregledUstanovaToolStripMenuItem.Click += new System.EventHandler(this.pregledUstanovaToolStripMenuItem_Click);
            // 
            // dodajUstanovuToolStripMenuItem
            // 
            this.dodajUstanovuToolStripMenuItem.Name = "dodajUstanovuToolStripMenuItem";
            this.dodajUstanovuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dodajUstanovuToolStripMenuItem.Text = "Dodaj ustanovu";
            this.dodajUstanovuToolStripMenuItem.Click += new System.EventHandler(this.dodajUstanovuToolStripMenuItem_Click);
            // 
            // bolestiToolStripMenuItem
            // 
            this.bolestiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledBolestiToolStripMenuItem,
            this.dodajBolestiToolStripMenuItem});
            this.bolestiToolStripMenuItem.Name = "bolestiToolStripMenuItem";
            this.bolestiToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.bolestiToolStripMenuItem.Text = "Bolesti";
            // 
            // pregledBolestiToolStripMenuItem
            // 
            this.pregledBolestiToolStripMenuItem.Name = "pregledBolestiToolStripMenuItem";
            this.pregledBolestiToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pregledBolestiToolStripMenuItem.Text = "Pregled bolesti";
            this.pregledBolestiToolStripMenuItem.Click += new System.EventHandler(this.pregledBolestiToolStripMenuItem_Click);
            // 
            // dodajBolestiToolStripMenuItem
            // 
            this.dodajBolestiToolStripMenuItem.Name = "dodajBolestiToolStripMenuItem";
            this.dodajBolestiToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dodajBolestiToolStripMenuItem.Text = "Dodaj bolesti";
            this.dodajBolestiToolStripMenuItem.Click += new System.EventHandler(this.dodajBolestiToolStripMenuItem_Click);
            // 
            // reakcijeToolStripMenuItem
            // 
            this.reakcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledReakcijaToolStripMenuItem,
            this.dodajReakcijuToolStripMenuItem});
            this.reakcijeToolStripMenuItem.Name = "reakcijeToolStripMenuItem";
            this.reakcijeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.reakcijeToolStripMenuItem.Text = "Reakcije";
            // 
            // pregledReakcijaToolStripMenuItem
            // 
            this.pregledReakcijaToolStripMenuItem.Name = "pregledReakcijaToolStripMenuItem";
            this.pregledReakcijaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pregledReakcijaToolStripMenuItem.Text = "Pregled reakcija";
            this.pregledReakcijaToolStripMenuItem.Click += new System.EventHandler(this.pregledReakcijaToolStripMenuItem_Click);
            // 
            // dodajReakcijuToolStripMenuItem
            // 
            this.dodajReakcijuToolStripMenuItem.Name = "dodajReakcijuToolStripMenuItem";
            this.dodajReakcijuToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dodajReakcijuToolStripMenuItem.Text = "Dodaj reakciju";
            this.dodajReakcijuToolStripMenuItem.Click += new System.EventHandler(this.dodajReakcijuToolStripMenuItem_Click);
            // 
            // msOtvoriZatvoriHladnjak
            // 
            this.msOtvoriZatvoriHladnjak.Name = "msOtvoriZatvoriHladnjak";
            this.msOtvoriZatvoriHladnjak.Size = new System.Drawing.Size(92, 20);
            this.msOtvoriZatvoriHladnjak.Text = "Otvori hladnjak";
            this.msOtvoriZatvoriHladnjak.Click += new System.EventHandler(this.msOtvoriZatvoriHladnjak_Click);
            // 
            // mjeracTemperature
            // 
            this.mjeracTemperature.Enabled = true;
            this.mjeracTemperature.Interval = 1000;
            this.mjeracTemperature.Tick += new System.EventHandler(this.mjeracTemperature_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLogiraniKorisnik,
            this.lblLogiraniUloga});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblLogiraniKorisnik
            // 
            this.lblLogiraniKorisnik.Name = "lblLogiraniKorisnik";
            this.lblLogiraniKorisnik.Size = new System.Drawing.Size(0, 17);
            // 
            // lblLogiraniUloga
            // 
            this.lblLogiraniUloga.Name = "lblLogiraniUloga";
            this.lblLogiraniUloga.Size = new System.Drawing.Size(0, 17);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            this.pomoćToolStripMenuItem.Click += new System.EventHandler(this.pomoćToolStripMenuItem_Click);
            // 
            // frmBankaKrvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBankaKrvi";
            this.Text = "Banka krvi | Glavni izbornik";
            this.Load += new System.EventHandler(this.frmBankaKrvi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPacijenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeNovogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledDonacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeDonacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transfuzijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem praćenjeStanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledTransfuzijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeTransfuzijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledStanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledHladnjakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajHladnjakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustanoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledUstanovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUstanovuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledBolestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajBolestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reakcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledReakcijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajReakcijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generiranjeListeDonoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msOtvoriZatvoriHladnjak;
        private System.Windows.Forms.Timer mjeracTemperature;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLogiraniKorisnik;
        private System.Windows.Forms.ToolStripStatusLabel lblLogiraniUloga;
        private System.Windows.Forms.ToolStripMenuItem potvrdaZaSlobodneDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
    }
}

