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
    public partial class frmHladnjak : Form
    {
        private bool kliknutoDodajDoze = false;

        public frmHladnjak()
        {
            InitializeComponent();
            this.CenterToParent();            
        }

        private void btnDodajDoze_Click(object sender, EventArgs e)
        {
            frmDodavanjeDoze DodajDoze = new frmDodavanjeDoze();
            DodajDoze.Show();
        }
    }
}
