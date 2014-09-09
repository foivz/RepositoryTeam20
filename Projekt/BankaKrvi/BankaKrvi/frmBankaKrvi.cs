using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaKrvi
{

    public partial class frmBankaKrvi : Form
    {
        public static List<int> podaciTemperatura = new List<int>();
        public static Boolean otvoren = false;
        int vrijemeOtvorenostiHladnjaka = 0;

        public frmBankaKrvi()
        {
            InitializeComponent();
            this.CenterToScreen();

            lblLogiraniKorisnik.Text = "Prijavljen kao: " + Sesija.ime + " " + Sesija.prezime;
            if (Sesija.uloga == 1)
            {
                lblLogiraniUloga.Text = " - Zaposlenik";

            }
            else if (Sesija.uloga == 2)
            {
                lblLogiraniUloga.Text = " - Administrator";
            }
            {

            }
        }

        private void provjeriAktivneForme()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }


        private void praćenjeStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodebljaniNazivPodizbornika(5);
            menuStrip2.Visible = true;
            VidljivostPodizbornika(9, 11);
            var margina = p9.Margin;
            margina.Top = 20;
            p9.Margin = margina;
            ZatvoriMargina();
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip2.Visible = false;
            PodebljaniNazivPodizbornika(6);
            provjeriAktivneForme();
            frmStatistikaAnalize StatistikaAnalize = new frmStatistikaAnalize();
            StatistikaAnalize.MdiParent = this;
            StatistikaAnalize.WindowState = FormWindowState.Maximized;
            StatistikaAnalize.Show();
        }

        private void frmBankaKrvi_Load(object sender, EventArgs e)
        {

            if (Sesija.uloga == 1)
            {
                adminToolStripMenuItem.Visible = false;
            }
        }

        private void mjeracTemperature_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randNum = 0;
            if (otvoren)
            {
                vrijemeOtvorenostiHladnjaka++;
                randNum = rand.Next(8, 12);
                if (vrijemeOtvorenostiHladnjaka % 10 == 0)
                {
                    MessageBox.Show("Upozorenje!\nHladnjak je otvoren već " + vrijemeOtvorenostiHladnjaka.ToString() + " sekundi");
                }
            }
            else
            {
                vrijemeOtvorenostiHladnjaka = 0;
                randNum = rand.Next(2, 6);
            }
            podaciTemperatura.Add(randNum);
        }

        private void msOtvoriZatvoriHladnjak_Click(object sender, EventArgs e)
        {
            if (otvoren)
            {
                msOtvoriZatvoriHladnjak.Text = "Otvori hladnjak";
                otvoren = false;
            }
            else
            {
                msOtvoriZatvoriHladnjak.Text = "Zatvori hladnjak";
                otvoren = true;
            }
            PodebljaniNazivPodizbornika(7);
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmStatistikaAnalize StatistikaAnalize = new frmStatistikaAnalize();
            StatistikaAnalize.MdiParent = this;
            StatistikaAnalize.WindowState = FormWindowState.Maximized;
            StatistikaAnalize.Show();
        }
               
        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("C:\\Users\\Filip\\Desktop\\PROJEKT\\Projektna dokumentacija\\Pomoc.pdf");
        }

        private void pacijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodebljaniNazivPodizbornika(1);
            menuStrip2.Visible = true;
            VidljivostPodizbornika(1, 4);
            var margina = p1.Margin;
            margina.Top = 20;
            p1.Margin = margina;
            ZatvoriMargina();
        }
        
        private void donacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodebljaniNazivPodizbornika(2);
            menuStrip2.Visible = true;
            VidljivostPodizbornika(5, 6);
            var margina = p5.Margin;
            margina.Top = 20;
            p5.Margin = margina;
            ZatvoriMargina();
        }

        private void transfuzijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodebljaniNazivPodizbornika(3);
            menuStrip2.Visible = true;
            VidljivostPodizbornika(7,8);
            var margina = p7.Margin;
            margina.Top = 20;
            p7.Margin = margina;
            ZatvoriMargina();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodebljaniNazivPodizbornika(4);
            menuStrip2.Visible = true;
            VidljivostPodizbornika(12, 19);
            var margina = p12.Margin;
            margina.Top = 20;
            p12.Margin = margina;
            ZatvoriMargina();
        }

        private void p1_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledPacijenata PregledPacijenata = new frmPregledPacijenata();
            PregledPacijenata.MdiParent = this;
            PregledPacijenata.WindowState = FormWindowState.Maximized;
            PregledPacijenata.Show();
        }

        private void p2_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjePacijenta DodavanjePacijenata = new frmDodavanjePacijenta(Pristup.kreiraj);
            DodavanjePacijenata.MdiParent = this;
            DodavanjePacijenata.WindowState = FormWindowState.Maximized;
            DodavanjePacijenata.Show();
        }

        private void p3_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmListaDonora ListaDonora = new frmListaDonora();
            ListaDonora.MdiParent = this;
            ListaDonora.WindowState = FormWindowState.Maximized;
            ListaDonora.Show();
        }

        private void p19_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmGenerirajPotvrdu GenerirajPotvrdu = new frmGenerirajPotvrdu();
            GenerirajPotvrdu.MdiParent = this;
            GenerirajPotvrdu.WindowState = FormWindowState.Maximized;
            GenerirajPotvrdu.Show();
        }

        private void p4_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledDonacija PregledDonacija = new frmPregledDonacija();
            PregledDonacija.MdiParent = this;
            PregledDonacija.WindowState = FormWindowState.Maximized;
            PregledDonacija.Show();
        }

        private void p5_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeDonacije DodavanjeDonacije = new frmDodavanjeDonacije(Pristup.kreiraj);
            DodavanjeDonacije.MdiParent = this;
            DodavanjeDonacije.WindowState = FormWindowState.Maximized;
            DodavanjeDonacije.Show();
        }

        private void p6_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledTransfuzija PregledTransfuzija = new frmPregledTransfuzija();
            PregledTransfuzija.MdiParent = this;
            PregledTransfuzija.WindowState = FormWindowState.Maximized;
            PregledTransfuzija.Show();
        }
        private void p7_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeTransfuzije DodavanjeTransfuzije = new frmDodavanjeTransfuzije();
            DodavanjeTransfuzije.MdiParent = this;
            DodavanjeTransfuzije.WindowState = FormWindowState.Maximized;
            DodavanjeTransfuzije.Show();
        }
        private void p8_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledStanjaKrvi ZaliheKrvi = new frmPregledStanjaKrvi();
            ZaliheKrvi.MdiParent = this;
            ZaliheKrvi.WindowState = FormWindowState.Maximized;
            ZaliheKrvi.Show();
        }

        private void p9_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledHladnjaka PregledHladnjaka = new frmPregledHladnjaka();
            PregledHladnjaka.MdiParent = this;
            PregledHladnjaka.WindowState = FormWindowState.Maximized;
            PregledHladnjaka.Show();
        }

        private void p10_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeHladnjaka DodavanjeHladnjaka = new frmDodavanjeHladnjaka();
            DodavanjeHladnjaka.MdiParent = this;
            DodavanjeHladnjaka.WindowState = FormWindowState.Maximized;
            DodavanjeHladnjaka.Show();
        }

        private void p11_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledZaposlenika PregledZaposlenika = new frmPregledZaposlenika();
            PregledZaposlenika.MdiParent = this;
            PregledZaposlenika.WindowState = FormWindowState.Maximized;
            PregledZaposlenika.Show();
        }

        private void p12_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeZaposlenika DodavanjeZaposlenika = new frmDodavanjeZaposlenika(Pristup.kreiraj);
            DodavanjeZaposlenika.MdiParent = this;
            DodavanjeZaposlenika.WindowState = FormWindowState.Maximized;
            DodavanjeZaposlenika.Show();

        }

        private void p13_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledUstanova PregledUstanova = new frmPregledUstanova();
            PregledUstanova.MdiParent = this;
            PregledUstanova.WindowState = FormWindowState.Maximized;
            PregledUstanova.Show();
        }

        private void p14_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeUstanova DodavanjeUstanova = new frmDodavanjeUstanova(Pristup.kreiraj);
            DodavanjeUstanova.MdiParent = this;
            DodavanjeUstanova.WindowState = FormWindowState.Maximized;
            DodavanjeUstanova.Show();
        }

        private void p15_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledBolesti PregledBolesti = new frmPregledBolesti();
            PregledBolesti.MdiParent = this;
            PregledBolesti.WindowState = FormWindowState.Maximized;
            PregledBolesti.Show();

        }

        private void p16_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeBolesti DodavanjeBolesti = new frmDodavanjeBolesti(Pristup.kreiraj);
            DodavanjeBolesti.MdiParent = this;
            DodavanjeBolesti.WindowState = FormWindowState.Maximized;
            DodavanjeBolesti.Show();
        }

        private void p17_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledReakcija PregledReakcija = new frmPregledReakcija();
            PregledReakcija.MdiParent = this;
            PregledReakcija.WindowState = FormWindowState.Maximized;
            PregledReakcija.Show();
        }

        private void p18_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeReakcija DodavanjeReakcija = new frmDodavanjeReakcija(Pristup.kreiraj);
            DodavanjeReakcija.MdiParent = this;
            DodavanjeReakcija.WindowState = FormWindowState.Maximized;
            DodavanjeReakcija.Show();
        }
        void VidljivostPodizbornika(int v1, int v2)
        {
            for (int i = 1; i <= 19; i++)
            {
                if (i >= v1 && i <= v2)
                {
                    switch (i)
                    {
                        case 1: p1.Visible = true; break;
                        case 2: p2.Visible = true; break;
                        case 3: p3.Visible = true; break;
                        case 4: p4.Visible = true; break;
                        case 5: p5.Visible = true; break;
                        case 6: p6.Visible = true; break;
                        case 7: p7.Visible = true; break;
                        case 8: p8.Visible = true; break;
                        case 9: p9.Visible = true; break;
                        case 10: p10.Visible = true; break;
                        case 11: p11.Visible = true; break;
                        case 12: p12.Visible = true; break;
                        case 13: p13.Visible = true; break;
                        case 14: p14.Visible = true; break;
                        case 15: p15.Visible = true; break;
                        case 16: p16.Visible = true; break;
                        case 17: p17.Visible = true; break;
                        case 18: p18.Visible = true; break;
                        case 19: p19.Visible = true; break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 1: p1.Visible = false; break;
                        case 2: p2.Visible = false; break;
                        case 3: p3.Visible = false; break;
                        case 4: p4.Visible = false; break;
                        case 5: p5.Visible = false; break;
                        case 6: p6.Visible = false; break;
                        case 7: p7.Visible = false; break;
                        case 8: p8.Visible = false; break;
                        case 9: p9.Visible = false; break;
                        case 10: p10.Visible = false; break;
                        case 11: p11.Visible = false; break;
                        case 12: p12.Visible = false; break;
                        case 13: p13.Visible = false; break;
                        case 14: p14.Visible = false; break;
                        case 15: p15.Visible = false; break;
                        case 16: p16.Visible = false; break;
                        case 17: p17.Visible = false; break;
                        case 18: p18.Visible = false; break;
                        case 19: p19.Visible = false; break;
                        default:
                            break;
                    }
                }
            }
        }
        void PodebljaniNazivPodizbornika(int p)
        {
            for (int i = 1; i <= 7; i++)
            {
                if (i == p)
                {
                    switch (i)
                    {
                        case 1: pacijentiToolStripMenuItem.Font = new System.Drawing.Font(pacijentiToolStripMenuItem.Font.FontFamily.Name, 10, FontStyle.Bold); break;
                        case 2: donacijeToolStripMenuItem.Font = new System.Drawing.Font(donacijeToolStripMenuItem.Font.FontFamily.Name, 10, FontStyle.Bold); break;
                        case 3: transfuzijeToolStripMenuItem.Font = new System.Drawing.Font(transfuzijeToolStripMenuItem.Font.FontFamily.Name, 10, FontStyle.Bold); break;
                        case 4: adminToolStripMenuItem.Font = new System.Drawing.Font(adminToolStripMenuItem.Font.FontFamily.Name, 10, FontStyle.Bold); break;
                        case 5: praćenjeStanjaToolStripMenuItem.Font = new System.Drawing.Font(praćenjeStanjaToolStripMenuItem.Font.FontFamily.Name, 10, FontStyle.Bold); break;
                        case 6: statistikaToolStripMenuItem.Font = new System.Drawing.Font(statistikaToolStripMenuItem.Font.FontFamily.Name, 10, FontStyle.Bold); break;
                        case 7: msOtvoriZatvoriHladnjak.Font = new System.Drawing.Font(msOtvoriZatvoriHladnjak.Font.FontFamily.Name, 10, FontStyle.Bold); break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 1: pacijentiToolStripMenuItem.Font = new System.Drawing.Font(pacijentiToolStripMenuItem.Font.FontFamily.Name, 9); break;
                        case 2: donacijeToolStripMenuItem.Font = new System.Drawing.Font(donacijeToolStripMenuItem.Font.FontFamily.Name, 9); break;
                        case 3: transfuzijeToolStripMenuItem.Font = new System.Drawing.Font(transfuzijeToolStripMenuItem.Font.FontFamily.Name, 9); break;
                        case 4: adminToolStripMenuItem.Font = new System.Drawing.Font(adminToolStripMenuItem.Font.FontFamily.Name, 9); break;
                        case 5: praćenjeStanjaToolStripMenuItem.Font = new System.Drawing.Font(praćenjeStanjaToolStripMenuItem.Font.FontFamily.Name, 9); break;
                        case 6: statistikaToolStripMenuItem.Font = new System.Drawing.Font(statistikaToolStripMenuItem.Font.FontFamily.Name, 9); break;
                        case 7: msOtvoriZatvoriHladnjak.Font = new System.Drawing.Font(msOtvoriZatvoriHladnjak.Font.FontFamily.Name, 9); break;

                        default:
                            break;
                    }

                }
            }
        }
        void ZatvoriMargina() 
        {
            var margina = zatvoriToolStripMenuItem.Margin;
            margina.Top = 20;
            zatvoriToolStripMenuItem.Margin = margina;
        }
        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip2.Visible = false;
        }
    }
}
