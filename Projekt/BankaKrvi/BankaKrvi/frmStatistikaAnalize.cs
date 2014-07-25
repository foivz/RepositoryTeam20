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

        private void btnPrikazi_MouseEnter(object sender, EventArgs e)
        {
            btnPrikazi.BackColor = Color.FromArgb(255, 51, 51);
            int x = btnPrikazi.Size.Width + 3;
            int y = btnPrikazi.Size.Height + 3;
            btnPrikazi.Size = new Size(x, y);
            btnPrikazi.Font = new System.Drawing.Font(btnPrikazi.Font.FontFamily.Name, 11, FontStyle.Bold);
        }

        private void btnPrikazi_MouseLeave(object sender, EventArgs e)
        {
            btnPrikazi.BackColor = Color.White;
            btnPrikazi.Size = new Size(136, 36);
            btnPrikazi.Font = new System.Drawing.Font(btnPrikazi.Font.FontFamily.Name, 10);
        }


    }
}
