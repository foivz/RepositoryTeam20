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
    public partial class frmPregledZaposlenika : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();

        public frmPregledZaposlenika()
        {
            InitializeComponent();
        }

        private void PrikaziZaposlenike()
        {
            BindingSource bsPregledZaposlenika = new BindingSource();
            bsPregledZaposlenika.DataSource = (from z in ctx.zaposlenik
                                               join t in ctx.tipzaposlenika on z.zaposlenik_tipZaposlenikaID equals t.tipZaposlenikaID
                                               join u in ctx.ustanova on z.zaposlenik_ustanovaID equals u.ustanovaID
                                              select new { z.ime, z.prezime, z.korisnickoIme, z.lozinka, z.email, z.telefon, tip = t.naziv, ustanova = u.naziv  }).ToList();



            dgvZaposlenici.DataSource = bsPregledZaposlenika;

        }

        private void frmPregledZaposlenika_Load(object sender, EventArgs e)
        {
            PrikaziZaposlenike();
        }
    }
}
