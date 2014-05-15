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
    public enum Pristup //: int
    {
        nista , azuriraj, kreiraj
    };

    public partial class frmDodavanjePacijenta : Form
    {
        private Pristup pristupPacijentu = Pristup.nista;

        public frmDodavanjePacijenta(Pristup PristupPacijentima_)
        {
            pristupPacijentu = PristupPacijentima_;

            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        private void PostaviFormu()
        {
            if (pristupPacijentu == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj pacijenta";
            }
            else if (pristupPacijentu == Pristup.kreiraj)
            {
                this.Text = "Kreiraj pacijenta";
            }
        }

        private void frmDodavanjePacijenta_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
