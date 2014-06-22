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
    public partial class frmPregledTransfuzija : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();

        public frmPregledTransfuzija()
        {
            InitializeComponent();
        }

        private void PrikaziTransfuzije()
        {
            BindingSource bsPregledTransfuzija = new BindingSource();
            bsPregledTransfuzija.DataSource = (from t in ctx.transfuzija
                                               join p in ctx.pacijent on t.transfuzija_pacijentID equals p.pacijentID
                                               join u in ctx.ustanova on t.transfuzija_ustanovaID equals u.ustanovaID
                                               join k in ctx.krvnagrupa on p.pacijent_krvnaGrupaID equals k.krvnaGrupaID
                                               select new { t.transfuzijaID, p.ime, p.prezime, u.naziv, t.povjest_bolesti, t.kolicina, krvnagrupa = k.naziv}).ToList();



            dgvTransfuzije.DataSource = bsPregledTransfuzija;

        }

        private void frmPregledTransfuzija_Load(object sender, EventArgs e)
        {
            PrikaziTransfuzije();
        }

                

        private void btnAzurirajTransfuzije_Click(object sender, EventArgs e)
        {
            int odabrano = Convert.ToInt32(dgvTransfuzije.CurrentRow.Cells[0].Value.ToString());

            frmDodavanjeTransfuzije DodavanjeTransfuzije = new frmDodavanjeTransfuzije(Pristup.azuriraj, odabrano);
            DodavanjeTransfuzije.MdiParent = this.MdiParent;
            DodavanjeTransfuzije.Show();
            this.Close();
        }

        private void btnPrikaziPosdatke_Click(object sender, EventArgs e)
        {
            int odabrano = Convert.ToInt32(dgvTransfuzije.CurrentRow.Cells[0].Value.ToString());
            BindingSource donacije = new BindingSource();
            BindingSource reakcije = new BindingSource();
            using (var db = new bankakrviEntities())
            {

                donacije.DataSource = (from d in db.donacija
                                       join p in db.pacijent on d.donacija_pacijentID equals p.pacijentID
                                       where d.transfuzija.FirstOrDefault().transfuzijaID == odabrano
                                       select new { d.donacijaID, d.vrijeme, d.napomena, d.kolicina, prezime = p.prezime, ime = p.ime }).ToList();

                /*reakcije.DataSource = (from t in db.transfuzija
                                       join p in db.pacijent on t.transfuzija_pacijentID equals p.pacijentID
                                       join tip in db.tipptreakcije on t.tipptreakcije.FirstOrDefault().tipPtReakcijeID equals tip.tipPtReakcijeID
                                       where t.transfuzijaID == odabrano
                                       select new { t.transfuzijaID, p.pacijentID, p.prezime, p.ime }).ToList();*/
            }
            dgvDonacije.DataSource = donacije;
            dgvReakcije.DataSource = reakcije;
        }
        


    }
}
