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
    public partial class frmPregledStanjaKrvi : Form
    {
        public frmPregledStanjaKrvi()
        {
            InitializeComponent();
        }

        private void btnPosaljiMail_Click(object sender, EventArgs e)
        {
            DialogResult odabir = MessageBox.Show("Poslati ćete mail donatorima s krvnom grupom","Slanje maila",MessageBoxButtons.YesNo);

            if (odabir == DialogResult.Yes)
            {
                MessageBox.Show("Odabrali ste da","Odgovor");
            }
            else if (odabir == DialogResult.No)
            {
                MessageBox.Show("Odabrali ste ne","Odgovor");
            }
        }
    }
}
