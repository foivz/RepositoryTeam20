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
    public partial class frmPregledHladnjaka : Form
    {
        public frmPregledHladnjaka()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnDetaljno_Click(object sender, EventArgs e)
        {
            frmHladnjak Hladnjak = new frmHladnjak();
            this.Hide();
            Hladnjak.ShowDialog();
            this.Show();
        }
    }
}
