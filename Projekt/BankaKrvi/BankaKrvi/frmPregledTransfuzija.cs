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
        


    }
}
