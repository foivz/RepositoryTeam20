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
            frmDodajTest AžurirajTest = new frmDodajTest(Pristup.azuriraj);
            this.Hide();
            AžurirajTest.ShowDialog();
            this.Show();
        }
    }
}
