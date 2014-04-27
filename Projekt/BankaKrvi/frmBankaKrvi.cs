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

        private void pregledPacijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPacijenata PregledPacijenata = new frmPregledPacijenata();
            this.Hide();
            PregledPacijenata.ShowDialog();
            this.Show();
        }

        private void dodavanjeNovogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjePacijenta DodavanjePacijenata = new frmDodavanjePacijenta(Pristup.kreiraj);
            this.Hide();
            DodavanjePacijenata.ShowDialog();
            this.Show();
        }

        private void pregledDonacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledDonacija PregledDonacija = new frmPregledDonacija();
            this.Hide();
            PregledDonacija.ShowDialog();
            this.Show();
        }

        private void dodavanjeDonacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeDonacije DodavanjeDonacije = new frmDodavanjeDonacije();
            this.Hide();
            DodavanjeDonacije.ShowDialog();
            this.Show();
        }

        private void dodavanjeTransfuzijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeTransfuzije DodavanjeTransfuzije = new frmDodavanjeTransfuzije();
            this.Hide();
            DodavanjeTransfuzije.ShowDialog();
            this.Show();
        }

        private void pregledTransfuzijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledTransfuzija PregledTransfuzija = new frmPregledTransfuzija();
            this.Hide();
            PregledTransfuzija.ShowDialog();
            this.Show();
        }

        private void pregledStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledStanjaKrvi ZaliheKrvi = new frmPregledStanjaKrvi();
            this.Hide();
            ZaliheKrvi.ShowDialog();
            this.Show();
        }

        private void pregledHladnjakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledHladnjaka PregledHladnjaka = new frmPregledHladnjaka();
            this.Hide();
            PregledHladnjaka.ShowDialog();
            this.Show();
        }

        private void praćenjeStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
