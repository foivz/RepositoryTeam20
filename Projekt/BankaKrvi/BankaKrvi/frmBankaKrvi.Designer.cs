namespace BankaKrvi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaKrvi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transfuzijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.praćenjeStanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msOtvoriZatvoriHladnjak = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjeracTemperature = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLogiraniKorisnik = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLogiraniUloga = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.p1 = new System.Windows.Forms.ToolStripMenuItem();
            this.p2 = new System.Windows.Forms.ToolStripMenuItem();
            this.p3 = new System.Windows.Forms.ToolStripMenuItem();
            this.p4 = new System.Windows.Forms.ToolStripMenuItem();
            this.p5 = new System.Windows.Forms.ToolStripMenuItem();
            this.p6 = new System.Windows.Forms.ToolStripMenuItem();
            this.p7 = new System.Windows.Forms.ToolStripMenuItem();
            this.p8 = new System.Windows.Forms.ToolStripMenuItem();
            this.p9 = new System.Windows.Forms.ToolStripMenuItem();
            this.p10 = new System.Windows.Forms.ToolStripMenuItem();
            this.p11 = new System.Windows.Forms.ToolStripMenuItem();
            this.p12 = new System.Windows.Forms.ToolStripMenuItem();
            this.p13 = new System.Windows.Forms.ToolStripMenuItem();
            this.p14 = new System.Windows.Forms.ToolStripMenuItem();
            this.p15 = new System.Windows.Forms.ToolStripMenuItem();
            this.p16 = new System.Windows.Forms.ToolStripMenuItem();
            this.p17 = new System.Windows.Forms.ToolStripMenuItem();
            this.p18 = new System.Windows.Forms.ToolStripMenuItem();
            this.p19 = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
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
            this.menuStrip1.Size = new System.Drawing.Size(1284, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacijentiToolStripMenuItem
            // 
            this.pacijentiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pacijentiToolStripMenuItem.Image")));
            this.pacijentiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pacijentiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(64, 50);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            this.pacijentiToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pacijentiToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pacijentiToolStripMenuItem.Click += new System.EventHandler(this.pacijentiToolStripMenuItem_Click);
            // 
            // donacijeToolStripMenuItem
            // 
            this.donacijeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donacijeToolStripMenuItem.Image")));
            this.donacijeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donacijeToolStripMenuItem.Name = "donacijeToolStripMenuItem";
            this.donacijeToolStripMenuItem.Size = new System.Drawing.Size(65, 50);
            this.donacijeToolStripMenuItem.Text = "Donacije";
            this.donacijeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.donacijeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.donacijeToolStripMenuItem.Click += new System.EventHandler(this.donacijeToolStripMenuItem_Click);
            // 
            // transfuzijeToolStripMenuItem
            // 
            this.transfuzijeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transfuzijeToolStripMenuItem.Image")));
            this.transfuzijeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transfuzijeToolStripMenuItem.Name = "transfuzijeToolStripMenuItem";
            this.transfuzijeToolStripMenuItem.Size = new System.Drawing.Size(76, 50);
            this.transfuzijeToolStripMenuItem.Text = "Transfuzije";
            this.transfuzijeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.transfuzijeToolStripMenuItem.Click += new System.EventHandler(this.transfuzijeToolStripMenuItem_Click);
            // 
            // praćenjeStanjaToolStripMenuItem
            // 
            this.praćenjeStanjaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("praćenjeStanjaToolStripMenuItem.Image")));
            this.praćenjeStanjaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.praćenjeStanjaToolStripMenuItem.Name = "praćenjeStanjaToolStripMenuItem";
            this.praćenjeStanjaToolStripMenuItem.Size = new System.Drawing.Size(69, 50);
            this.praćenjeStanjaToolStripMenuItem.Text = "Hladnjaci";
            this.praćenjeStanjaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.praćenjeStanjaToolStripMenuItem.Click += new System.EventHandler(this.praćenjeStanjaToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statistikaToolStripMenuItem.Image")));
            this.statistikaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(111, 50);
            this.statistikaToolStripMenuItem.Text = "Statistika i analize";
            this.statistikaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminToolStripMenuItem.Image")));
            this.adminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(137, 50);
            this.adminToolStripMenuItem.Text = "Administracija sustava";
            this.adminToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // msOtvoriZatvoriHladnjak
            // 
            this.msOtvoriZatvoriHladnjak.Image = ((System.Drawing.Image)(resources.GetObject("msOtvoriZatvoriHladnjak.Image")));
            this.msOtvoriZatvoriHladnjak.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msOtvoriZatvoriHladnjak.Name = "msOtvoriZatvoriHladnjak";
            this.msOtvoriZatvoriHladnjak.Size = new System.Drawing.Size(100, 50);
            this.msOtvoriZatvoriHladnjak.Text = "Otvori hladnjak";
            this.msOtvoriZatvoriHladnjak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.msOtvoriZatvoriHladnjak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.msOtvoriZatvoriHladnjak.Click += new System.EventHandler(this.msOtvoriZatvoriHladnjak_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pomoćToolStripMenuItem.Image")));
            this.pomoćToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pomoćToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 50);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            this.pomoćToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pomoćToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pomoćToolStripMenuItem.Click += new System.EventHandler(this.pomoćToolStripMenuItem_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
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
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.p1,
            this.p2,
            this.p3,
            this.p4,
            this.p5,
            this.p6,
            this.p7,
            this.p8,
            this.p9,
            this.p10,
            this.p11,
            this.p12,
            this.p13,
            this.p14,
            this.p15,
            this.p16,
            this.p17,
            this.p18,
            this.p19,
            this.zatvoriToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 54);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(181, 621);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Visible = false;
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.p1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(168, 21);
            this.p1.Text = "Pregled pacijenata";
            this.p1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p1.Visible = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // p2
            // 
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(168, 33);
            this.p2.Text = "Dodavanje novog";
            this.p2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p2.Visible = false;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // p3
            // 
            this.p3.Image = ((System.Drawing.Image)(resources.GetObject("p3.Image")));
            this.p3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(168, 34);
            this.p3.Text = "Generiranje liste donora";
            this.p3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p3.Visible = false;
            this.p3.Click += new System.EventHandler(this.p3_Click);
            // 
            // p4
            // 
            this.p4.Image = ((System.Drawing.Image)(resources.GetObject("p4.Image")));
            this.p4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(168, 33);
            this.p4.Text = "Potvrda za slobodne dane";
            this.p4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p4.Visible = false;
            this.p4.Click += new System.EventHandler(this.p19_Click);
            // 
            // p5
            // 
            this.p5.Image = ((System.Drawing.Image)(resources.GetObject("p5.Image")));
            this.p5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(168, 21);
            this.p5.Text = "Pregled donacija";
            this.p5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p5.Visible = false;
            this.p5.Click += new System.EventHandler(this.p4_Click);
            // 
            // p6
            // 
            this.p6.Image = ((System.Drawing.Image)(resources.GetObject("p6.Image")));
            this.p6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(168, 33);
            this.p6.Text = "Dodavanje donacija";
            this.p6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p6.Visible = false;
            this.p6.Click += new System.EventHandler(this.p5_Click);
            // 
            // p7
            // 
            this.p7.Image = ((System.Drawing.Image)(resources.GetObject("p7.Image")));
            this.p7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(168, 21);
            this.p7.Text = "Pregled transfuzija";
            this.p7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p7.Visible = false;
            this.p7.Click += new System.EventHandler(this.p6_Click);
            // 
            // p8
            // 
            this.p8.Image = ((System.Drawing.Image)(resources.GetObject("p8.Image")));
            this.p8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(168, 33);
            this.p8.Text = "Dodavanje transfuzije";
            this.p8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p8.Visible = false;
            this.p8.Click += new System.EventHandler(this.p7_Click);
            // 
            // p9
            // 
            this.p9.Image = ((System.Drawing.Image)(resources.GetObject("p9.Image")));
            this.p9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(168, 21);
            this.p9.Text = "Pregled zaliha krvi";
            this.p9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p9.Visible = false;
            this.p9.Click += new System.EventHandler(this.p8_Click);
            // 
            // p10
            // 
            this.p10.Image = ((System.Drawing.Image)(resources.GetObject("p10.Image")));
            this.p10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(168, 21);
            this.p10.Text = "Pregled hladnjaka";
            this.p10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p10.Visible = false;
            this.p10.Click += new System.EventHandler(this.p9_Click);
            // 
            // p11
            // 
            this.p11.Image = ((System.Drawing.Image)(resources.GetObject("p11.Image")));
            this.p11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(168, 33);
            this.p11.Text = "Dodaj hladnjak";
            this.p11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p11.Visible = false;
            this.p11.Click += new System.EventHandler(this.p10_Click);
            // 
            // p12
            // 
            this.p12.Image = ((System.Drawing.Image)(resources.GetObject("p12.Image")));
            this.p12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p12.Name = "p12";
            this.p12.Size = new System.Drawing.Size(168, 21);
            this.p12.Text = "Pregled zaposlenika";
            this.p12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p12.Visible = false;
            this.p12.Click += new System.EventHandler(this.p11_Click);
            // 
            // p13
            // 
            this.p13.Image = ((System.Drawing.Image)(resources.GetObject("p13.Image")));
            this.p13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p13.Name = "p13";
            this.p13.Size = new System.Drawing.Size(168, 33);
            this.p13.Text = "Dodaj zaposlenika";
            this.p13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p13.Visible = false;
            this.p13.Click += new System.EventHandler(this.p12_Click);
            // 
            // p14
            // 
            this.p14.Image = ((System.Drawing.Image)(resources.GetObject("p14.Image")));
            this.p14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p14.Name = "p14";
            this.p14.Size = new System.Drawing.Size(168, 21);
            this.p14.Text = "Pregled ustanove";
            this.p14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p14.Visible = false;
            this.p14.Click += new System.EventHandler(this.p13_Click);
            // 
            // p15
            // 
            this.p15.Image = ((System.Drawing.Image)(resources.GetObject("p15.Image")));
            this.p15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p15.Name = "p15";
            this.p15.Size = new System.Drawing.Size(168, 33);
            this.p15.Text = "Dodaj ustanovu";
            this.p15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p15.Visible = false;
            this.p15.Click += new System.EventHandler(this.p14_Click);
            // 
            // p16
            // 
            this.p16.Image = ((System.Drawing.Image)(resources.GetObject("p16.Image")));
            this.p16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p16.Name = "p16";
            this.p16.Size = new System.Drawing.Size(168, 21);
            this.p16.Text = "Pregled bolesti";
            this.p16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p16.Visible = false;
            this.p16.Click += new System.EventHandler(this.p15_Click);
            // 
            // p17
            // 
            this.p17.Image = ((System.Drawing.Image)(resources.GetObject("p17.Image")));
            this.p17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p17.Name = "p17";
            this.p17.Size = new System.Drawing.Size(168, 33);
            this.p17.Text = "Dodaj bolest";
            this.p17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.p17.Visible = false;
            this.p17.Click += new System.EventHandler(this.p16_Click);
            // 
            // p18
            // 
            this.p18.Image = ((System.Drawing.Image)(resources.GetObject("p18.Image")));
            this.p18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p18.Name = "p18";
            this.p18.Size = new System.Drawing.Size(168, 21);
            this.p18.Text = "Pregled reakcija";
            this.p18.Visible = false;
            this.p18.Click += new System.EventHandler(this.p17_Click);
            // 
            // p19
            // 
            this.p19.Image = ((System.Drawing.Image)(resources.GetObject("p19.Image")));
            this.p19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.p19.Name = "p19";
            this.p19.Size = new System.Drawing.Size(168, 33);
            this.p19.Text = "Dodaj reakciju";
            this.p19.Visible = false;
            this.p19.Click += new System.EventHandler(this.p18_Click);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zatvoriToolStripMenuItem.Image")));
            this.zatvoriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zatvoriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // frmBankaKrvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 697);
            this.Controls.Add(this.menuStrip2);
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
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transfuzijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem praćenjeStanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msOtvoriZatvoriHladnjak;
        private System.Windows.Forms.Timer mjeracTemperature;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLogiraniKorisnik;
        private System.Windows.Forms.ToolStripStatusLabel lblLogiraniUloga;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem p1;
        private System.Windows.Forms.ToolStripMenuItem p2;
        private System.Windows.Forms.ToolStripMenuItem p3;
        private System.Windows.Forms.ToolStripMenuItem p5;
        private System.Windows.Forms.ToolStripMenuItem p6;
        private System.Windows.Forms.ToolStripMenuItem p7;
        private System.Windows.Forms.ToolStripMenuItem p8;
        private System.Windows.Forms.ToolStripMenuItem p9;
        private System.Windows.Forms.ToolStripMenuItem p10;
        private System.Windows.Forms.ToolStripMenuItem p11;
        private System.Windows.Forms.ToolStripMenuItem p12;
        private System.Windows.Forms.ToolStripMenuItem p13;
        private System.Windows.Forms.ToolStripMenuItem p14;
        private System.Windows.Forms.ToolStripMenuItem p15;
        private System.Windows.Forms.ToolStripMenuItem p16;
        private System.Windows.Forms.ToolStripMenuItem p17;
        private System.Windows.Forms.ToolStripMenuItem p18;
        private System.Windows.Forms.ToolStripMenuItem p19;
        private System.Windows.Forms.ToolStripMenuItem p4;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
    }
}

