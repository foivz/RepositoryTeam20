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
    public partial class frmPregledDonacija : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();
        public frmPregledDonacija()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnDodajTest_Click(object sender, EventArgs e)
        {
            frmDodajTest DodajTest = new frmDodajTest(Pristup.kreiraj);
            this.Hide();
            DodajTest.ShowDialog();
            this.Show();
        }

        private void btnAzurirajTest_Click(object sender, EventArgs e)
        {
            int odabrano = Convert.ToInt32(dgvTestovi.CurrentRow.Cells[0].Value.ToString());
            frmDodajTest AzurirajTest = new frmDodajTest(Pristup.azuriraj, odabrano);
            this.Hide();
            AzurirajTest.ShowDialog();
            this.Show();
        }



        private void PrikaziDonacije()
        {
            BindingSource bsPregledDonacija = new BindingSource();
            bsPregledDonacija.DataSource = (from d in ctx.donacija
                                              join p in ctx.pacijent on d.donacija_pacijentID equals p.pacijentID
                                              join h in ctx.hladnjak on d.donacija_hladnjakID equals h.hladnjakID
                                              join z in ctx.zaposlenik on d.donacija_zaposlenikID equals z.zaposlenikID
                                              select new { d.donacijaID, d.vrijeme, d.napomena, pacijent = p.ime +" "+ p.prezime, hladnjak = h.naziv, zaposlenik = z.ime +" "+ z.prezime}).ToList();



            dgvDonacije.DataSource = bsPregledDonacija;

        }

        private void PrikaziTestove(int brojTesta) 
        {
            int d = brojTesta + 1;
            BindingSource bsPregledDonacija = new BindingSource();
            bsPregledDonacija.DataSource = (from t in ctx.test
                                            join u in ctx.ustanova on t.test_ustanovaID equals u.ustanovaID
                                            join b in ctx.bolest on t.test_bolestID equals b.bolestID
                                            where t.test_donacijaID == d
                                            select new { t.testID, t.odobren, t.vrijeme, ustanova = u.naziv, bolest = b.naziv }).ToList();



            dgvTestovi.DataSource = bsPregledDonacija;
            
        }

        private void frmPregledDonacija_Load(object sender, EventArgs e)
        {
            PrikaziDonacije();
            
        }

        private void dgvDonacije_SelectionChanged(object sender, EventArgs e)
        {
            int brojTesta = Convert.ToInt16(dgvDonacije.CurrentRow.Index);
            PrikaziTestove(brojTesta);
        }

      
    }
}
