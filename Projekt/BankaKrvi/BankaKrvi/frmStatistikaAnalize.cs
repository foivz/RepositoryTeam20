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
    public partial class frmStatistikaAnalize : Form
    {
        public frmStatistikaAnalize()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            string odabrano = cboxKategorije.Text;
            if (odabrano == "Donacije")
            {
                frmStatistikaDonacije statistikaDonacije = new frmStatistikaDonacije();
                statistikaDonacije.MdiParent = this.MdiParent;
                statistikaDonacije.Show();
                this.Close();   
            }
            else if (odabrano == "Transfuzije")
            {
                /*frmStatistikaDonacije statistikaDonacije = new frmStatistikaDonacije();
                statistikaDonacije.MdiParent = this.MdiParent;
                statistikaDonacije.Show();
                this.Close();*/
            }
            else 
            {
                MessageBox.Show("Odaberite kategoriju za prikaz");
            }
            
            
        }
    }
}
