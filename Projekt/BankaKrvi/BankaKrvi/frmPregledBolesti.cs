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
    public partial class frmPregledBolesti : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();
        public frmPregledBolesti()
        {
            InitializeComponent();
        }

        private void PrikaziBolesti()
        {
            BindingSource bsPregledBolesti = new BindingSource();
            bsPregledBolesti.DataSource = (from b in ctx.bolest
                                            select new { b.bolestID, b.naziv }).ToList();



            dgvBolesti.DataSource = bsPregledBolesti;

        }

        private void frmPregledBolesti_Load(object sender, EventArgs e)
        {
            PrikaziBolesti();

        }

        private void btnAzurirajBolest_Click(object sender, EventArgs e)
        {
            int odabrano = int.Parse(dgvBolesti.CurrentRow.Cells[0].Value.ToString());
            frmDodavanjeBolesti AzurirajBolesti = new frmDodavanjeBolesti(Pristup.azuriraj, odabrano);
            AzurirajBolesti.MdiParent = this.MdiParent;
            AzurirajBolesti.Show();
            this.Close();
        }
    }
}
