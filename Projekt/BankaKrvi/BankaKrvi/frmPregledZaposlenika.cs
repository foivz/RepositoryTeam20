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
            this.CenterToParent();
        }

        private void PrikaziZaposlenike()
        {
            BindingSource bsPregledZaposlenika = new BindingSource();
            bsPregledZaposlenika.DataSource = (from z in ctx.zaposlenik
                                               join t in ctx.tipzaposlenika on z.zaposlenik_tipZaposlenikaID equals t.tipZaposlenikaID
                                               join u in ctx.ustanova on z.zaposlenik_ustanovaID equals u.ustanovaID
                                              select new { z.zaposlenikID, z.ime, z.prezime, z.korisnickoIme, z.lozinka, z.email, z.telefon, tip = t.naziv, ustanova = u.naziv  }).ToList();



            dgvZaposlenici.DataSource = bsPregledZaposlenika;

        }

        private void frmPregledZaposlenika_Load(object sender, EventArgs e)
        {
            PrikaziZaposlenike();
        }

        private void btnAzurirajZaposlenika_Click(object sender, EventArgs e)
        {
            int odabrano = int.Parse(dgvZaposlenici.CurrentRow.Cells[0].Value.ToString());
            frmDodavanjeZaposlenika AzurirajZaposlenika = new frmDodavanjeZaposlenika(Pristup.azuriraj, odabrano);
            AzurirajZaposlenika.MdiParent = this.MdiParent;
            AzurirajZaposlenika.Show();
            this.Close();
        }

        private void btnAzurirajZaposlenika_MouseEnter(object sender, EventArgs e)
        {
            btnAzurirajZaposlenika.BackColor = Color.FromArgb(255, 51, 51);
            int x = btnAzurirajZaposlenika.Size.Width + 3;
            int y = btnAzurirajZaposlenika.Size.Height + 3;
            btnAzurirajZaposlenika.Size = new Size(x, y);
            btnAzurirajZaposlenika.Font = new System.Drawing.Font(btnAzurirajZaposlenika.Font.FontFamily.Name, 11, FontStyle.Bold);
        }

        private void btnAzurirajZaposlenika_MouseLeave(object sender, EventArgs e)
        {
            btnAzurirajZaposlenika.BackColor = Color.White;
            btnAzurirajZaposlenika.Size = new Size(184, 38);
            btnAzurirajZaposlenika.Font = new System.Drawing.Font(btnAzurirajZaposlenika.Font.FontFamily.Name, 10);
        }
    }
}
