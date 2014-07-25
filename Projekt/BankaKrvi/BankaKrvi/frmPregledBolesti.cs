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

        private void btnAzurirajBolest_MouseEnter(object sender, EventArgs e)
        {
            btnAzurirajBolest.BackColor = Color.FromArgb(255, 51, 51);
            int x = btnAzurirajBolest.Size.Width + 3;
            int y = btnAzurirajBolest.Size.Height + 3;
            btnAzurirajBolest.Size = new Size(x, y);
            btnAzurirajBolest.Font = new System.Drawing.Font(btnAzurirajBolest.Font.FontFamily.Name, 11, FontStyle.Bold);
        }

        private void btnAzurirajBolest_MouseLeave(object sender, EventArgs e)
        {
            btnAzurirajBolest.BackColor = Color.White;
            btnAzurirajBolest.Size = new Size(164, 34);
            btnAzurirajBolest.Font = new System.Drawing.Font(btnAzurirajBolest.Font.FontFamily.Name, 10);
        }
    }
}
