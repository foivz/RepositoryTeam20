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
    public partial class frmPregledPacijenata : Form
    {
        public frmPregledPacijenata()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnAzurirajPacijenta_Click(object sender, EventArgs e)
        {
            frmDodavanjePacijenta DodavanjePacijenta = new frmDodavanjePacijenta(Pristup.azuriraj);
            this.Hide();
            DodavanjePacijenta.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
