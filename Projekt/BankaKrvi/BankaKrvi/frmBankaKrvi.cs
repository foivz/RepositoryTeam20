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
        public frmBankaKrvi()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void provjeriAktivneForme()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }


        private void pregledPacijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledPacijenata PregledPacijenata = new frmPregledPacijenata();
            PregledPacijenata.MdiParent = this;
            PregledPacijenata.WindowState = FormWindowState.Maximized;
            PregledPacijenata.Show();
        }

        private void dodavanjeNovogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjePacijenta DodavanjePacijenata = new frmDodavanjePacijenta(Pristup.kreiraj);
            DodavanjePacijenata.MdiParent = this;
            DodavanjePacijenata.WindowState = FormWindowState.Maximized;
            DodavanjePacijenata.Show();
        }

        private void pregledDonacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledDonacija PregledDonacija = new frmPregledDonacija();
            PregledDonacija.MdiParent = this;
            PregledDonacija.WindowState = FormWindowState.Maximized;
            PregledDonacija.Show();
        }

        private void dodavanjeDonacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeDonacije DodavanjeDonacije = new frmDodavanjeDonacije();
            DodavanjeDonacije.MdiParent = this;
            DodavanjeDonacije.WindowState = FormWindowState.Maximized;
            DodavanjeDonacije.Show();
        }

        private void dodavanjeTransfuzijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeTransfuzije DodavanjeTransfuzije = new frmDodavanjeTransfuzije();
            DodavanjeTransfuzije.MdiParent = this;
            DodavanjeTransfuzije.WindowState = FormWindowState.Maximized;
            DodavanjeTransfuzije.Show();
        }

        private void pregledTransfuzijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledTransfuzija PregledTransfuzija = new frmPregledTransfuzija();
            PregledTransfuzija.MdiParent = this;
            PregledTransfuzija.WindowState = FormWindowState.Maximized;
            PregledTransfuzija.Show();
        }

        private void pregledStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledStanjaKrvi ZaliheKrvi = new frmPregledStanjaKrvi();
            ZaliheKrvi.MdiParent = this;
            ZaliheKrvi.WindowState = FormWindowState.Maximized;
            ZaliheKrvi.Show();
        }

        private void pregledHladnjakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledHladnjaka PregledHladnjaka = new frmPregledHladnjaka();
            PregledHladnjaka.MdiParent = this;
            PregledHladnjaka.WindowState = FormWindowState.Maximized;
            PregledHladnjaka.Show();
        }

        private void praćenjeStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmBankaKrvi_Load(object sender, EventArgs e)
        {

        }

        private void generiranjeListeDonoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmListaDonora ListaDonora = new frmListaDonora();
            ListaDonora.MdiParent = this;
            ListaDonora.WindowState = FormWindowState.Maximized;
            ListaDonora.Show();

        }

        private void pregledZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledZaposlenika PregledZaposlenika = new frmPregledZaposlenika();
            PregledZaposlenika.MdiParent = this;
            PregledZaposlenika.WindowState = FormWindowState.Maximized;
            PregledZaposlenika.Show();

        }

        private void pregledUstanovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledUstanova PregledUstanova = new frmPregledUstanova();
            PregledUstanova.MdiParent = this;
            PregledUstanova.WindowState = FormWindowState.Maximized;
            PregledUstanova.Show();

        }

        private void pregledBolestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledBolesti PregledBolesti = new frmPregledBolesti();
            PregledBolesti.MdiParent = this;
            PregledBolesti.WindowState = FormWindowState.Maximized;
            PregledBolesti.Show();


        }

        private void pregledReakcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmPregledReakcija PregledReakcija = new frmPregledReakcija();
            PregledReakcija.MdiParent = this;
            PregledReakcija.WindowState = FormWindowState.Maximized;
            PregledReakcija.Show();

        }

        private void dodajZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            provjeriAktivneForme();
            frmDodavanjeZaposlenika DodavanjeZaposlenika = new frmDodavanjeZaposlenika(Pristup.kreiraj);
            DodavanjeZaposlenika.MdiParent = this;
            DodavanjeZaposlenika.WindowState = FormWindowState.Maximized;
            DodavanjeZaposlenika.Show();


        }
    }
}
