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
        /*int zaposlenikID = 0;
        string ime = "";
        string prezime = "";
        int uloga = 0;*/

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
                    int zaposlenikID = z.zaposlenikID;
                    string ime = z.ime;
                    string prezime = z.prezime;
                    int uloga = z.zaposlenik_tipZaposlenikaID;

                    Sesija.zaposlenikID = zaposlenikID;
                    Sesija.ime = ime;
                    Sesija.prezime = prezime;
                    Sesija.uloga = uloga;
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

        

        private void txtPrkKorIme_MouseLeave(object sender, EventArgs e)
        {
            txtPrkKorIme.BackColor = Color.White;
            txtPrkKorIme.Size = new Size(127, 20);
        }


        private void txtPrkLozinka_MouseLeave(object sender, EventArgs e)
        {
            txtPrkLozinka.BackColor = Color.White;
            txtPrkLozinka.Size = new Size(127, 20);
        }

        private void btnPrkPrijavi_MouseLeave(object sender, EventArgs e)
        {
            btnPrkPrijavi.BackColor = Color.White;
            btnPrkPrijavi.Size = new Size(180, 30);
            btnPrkPrijavi.Font = new System.Drawing.Font(btnPrkPrijavi.Font.FontFamily.Name, 10);
        }

        private void btnPrkPrijavi_MouseEnter(object sender, EventArgs e)
        {
            btnPrkPrijavi.BackColor = Color.FromArgb(255, 51, 51);
            int x = btnPrkPrijavi.Size.Width + 3;
            int y = btnPrkPrijavi.Size.Height + 3;
            btnPrkPrijavi.Size = new Size(x, y);
            btnPrkPrijavi.Font = new System.Drawing.Font(btnPrkPrijavi.Font.FontFamily.Name, 11, FontStyle.Bold);
        }

        private void txtPrkKorIme_MouseEnter(object sender, EventArgs e)
        {
            txtPrkKorIme.BackColor = Color.FromArgb(204, 255, 255);
            int x = txtPrkKorIme.Size.Width + 3;
            int y = txtPrkKorIme.Size.Height + 3;
            txtPrkKorIme.Size = new Size(x, y);
        }

        private void txtPrkLozinka_MouseEnter(object sender, EventArgs e)
        {
            txtPrkLozinka.BackColor = Color.FromArgb(204, 255, 255);
            int x = txtPrkLozinka.Size.Width + 3;
            int y = txtPrkLozinka.Size.Height + 3;
            txtPrkLozinka.Size = new Size(x, y);
        }
    }
}
