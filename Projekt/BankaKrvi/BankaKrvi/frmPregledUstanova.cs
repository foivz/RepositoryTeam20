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
    public partial class frmPregledUstanova : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();

        public frmPregledUstanova()
        {
            InitializeComponent();
        }

        private void PrikaziUstanove()
        {
            BindingSource bsPregledUstanova = new BindingSource();
            bsPregledUstanova.DataSource = (from u in ctx.ustanova
                                            select new { u.ustanovaID, u.naziv, u.adresa, u.email, u.telefon }).ToList();



            dgvUstanove.DataSource = bsPregledUstanova;

        }

        private void frmPregledUstanova_Load(object sender, EventArgs e)
        {
            PrikaziUstanove();
        }

        private void btnAzurirajUStanovu_Click(object sender, EventArgs e)
        {
            int odabrano = int.Parse(dgvUstanove.CurrentRow.Cells[0].Value.ToString());
            frmDodavanjeUstanova AzurirajUstanove = new frmDodavanjeUstanova(Pristup.azuriraj, odabrano);
            AzurirajUstanove.MdiParent = this.MdiParent;
            AzurirajUstanove.Show();
            this.Close();
        }
    }
}
