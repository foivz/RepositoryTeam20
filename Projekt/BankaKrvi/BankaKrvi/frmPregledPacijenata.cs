using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace BankaKrvi
{
    public partial class frmPregledPacijenata : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();

        public frmPregledPacijenata()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnAzurirajPacijenta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAzurirajPacijent_Click(object sender, EventArgs e)
        {
            int odabrano = Convert.ToInt32(dgvPacijenti.CurrentRow.Cells[0].Value.ToString());

            frmDodavanjePacijenta DodavanjePacijenta = new frmDodavanjePacijenta(Pristup.azuriraj, odabrano);
            DodavanjePacijenta.MdiParent = this.MdiParent;
            DodavanjePacijenta.Show();
            this.Close();
        }


        private void PrikaziPacijente()
        {
            BindingSource bsPregledPacijenata = new BindingSource();
            bsPregledPacijenata.DataSource = (from p in ctx.pacijent
                                         join t in ctx.tippacijenta on p.pacijent_tipPacijentaID equals t.tipKorisnikaID
                                         join s in ctx.spol on p.pacijent_spolID equals s.spolID
                                         join k in ctx.krvnagrupa on p.pacijent_krvnaGrupaID equals k.krvnaGrupaID
                                         select new { p.pacijentID, p.OIB, p.ime, p.prezime, p.brojPoliceOsiguranja, p.adresa, p.telefon, p.email, p.tezina, p.datum_rodenja, krvnaGrupa = k.naziv, tipPacijenta = t.naziv, spol = s.naziv }).ToList();



            dgvPacijenti.DataSource = bsPregledPacijenata;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        
        
        private void frmPregledPacijenata_Load(object sender, EventArgs e)
        {
            PrikaziPacijente();
        }
    }
}
