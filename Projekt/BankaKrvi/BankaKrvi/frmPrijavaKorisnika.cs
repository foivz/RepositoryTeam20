using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace BankaKrvi
{
    public partial class frmPrijavaKorisnika : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();

        public frmPrijavaKorisnika()
        {
            InitializeComponent();
        }

        private void btnPrkPrijavi_Click(object sender, EventArgs e)
        {
            if (txtPrkKorIme.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime!");
            }
            else if (txtPrkLozinka.Text == "") 
            {
                MessageBox.Show("Unesite lozinku!");
            }

            bool postoji = false;
            string korIme, lozinka;
            korIme = txtPrkKorIme.Text;
            lozinka = txtPrkLozinka.Text;

            bankakrviEntities db = new bankakrviEntities();
            var zaposlenik = db.zaposlenik;   
            foreach (var z in zaposlenik)
            {
                if (z.korisnickoIme == korIme && z.lozinka == lozinka)
                {
                    postoji = true;
                    break;
                } 
            }
            if (!postoji)
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
            }
            else 
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
