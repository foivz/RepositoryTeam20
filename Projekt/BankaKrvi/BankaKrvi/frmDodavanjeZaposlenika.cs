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
    public partial class frmDodavanjeZaposlenika : Form
    {
        private Pristup pristupZaposleniku = Pristup.nista;
        private zaposlenik z;
        private int odabranZaposlenik;

        public frmDodavanjeZaposlenika(Pristup PristupZaposlenicima_)
        {
            
            pristupZaposleniku= PristupZaposlenicima_;

            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        
        }

        public frmDodavanjeZaposlenika(Pristup PristupZaposlenicima_, int odabrano)
        {
            pristupZaposleniku = PristupZaposlenicima_;
            odabranZaposlenik = odabrano;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        private void PostaviFormu()
        {
            if (pristupZaposleniku == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj podatke zaposlenika";
                btnDodajZaposlenika.Text = "";
            }
            else if (pristupZaposleniku == Pristup.kreiraj)
            {
                this.Text = "Dodaj novog zaposlenika";
            }
        }

        private void frmDodavanjeZaposlenika_Load(object sender, EventArgs e)
        {
            if (pristupZaposleniku == Pristup.azuriraj)
            {
                DohvatiPodatke();
                using (var db = new bankakrviEntities())
                {
                    z = db.zaposlenik.Where(x => x.zaposlenikID.Equals(odabranZaposlenik)).First();
                    tboxZapIme.Text = z.ime;
                    tboxZapPrezime.Text = z.prezime;
                    tboxZapKorIme.Text = z.korisnickoIme;
                    tboxZapLozinka.Text = z.lozinka;
                    tboxZapEmail.Text = z.email;
                    tboxZapTelefon.Text = z.telefon;
                    cboxZapTip.SelectedValue = z.zaposlenik_tipZaposlenikaID;
                    cboxZapUstanova.SelectedValue = z.zaposlenik_ustanovaID;

                }

            }
            else if (pristupZaposleniku == Pristup.kreiraj)
            {
                DohvatiPodatke();
            }
        }

        private void DohvatiPodatke()
        {
            using (var db = new bankakrviEntities())
            {
                cboxZapTip.DataSource = db.tipzaposlenika.ToList();
                cboxZapTip.ValueMember = "tipZaposlenikaID";
                cboxZapTip.DisplayMember = "naziv";

                cboxZapUstanova.DataSource = db.ustanova.ToList();
                cboxZapUstanova.ValueMember = "ustanovaID";
                cboxZapUstanova.DisplayMember = "naziv";
            }
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities())
            {
                if (pristupZaposleniku == Pristup.kreiraj)
                {
                    z = new zaposlenik();
                }
                else if (pristupZaposleniku == Pristup.azuriraj)
                {
                    db.zaposlenik.Attach(z);
                }

                z.ime = tboxZapIme.Text;
                z.prezime = tboxZapPrezime.Text;
                z.korisnickoIme = tboxZapKorIme.Text;
                z.lozinka = tboxZapLozinka.Text;
                z.email = tboxZapEmail.Text;
                z.telefon = tboxZapTelefon.Text;
                z.zaposlenik_tipZaposlenikaID = Convert.ToInt32(cboxZapTip.SelectedValue);
                z.zaposlenik_ustanovaID = Convert.ToInt32(cboxZapUstanova.SelectedValue);

                if (pristupZaposleniku == Pristup.kreiraj)
                {
                    db.zaposlenik.Add(z);
                }


                db.SaveChanges();
                if (pristupZaposleniku == Pristup.kreiraj)
                {
                    MessageBox.Show("Uspješno ste dodali zaposlenika");
                }
                else if (pristupZaposleniku == Pristup.azuriraj)
                {
                    
                    MessageBox.Show("Uspješno ste azurirali");
                }


                frmPregledZaposlenika zaposlenik = new frmPregledZaposlenika();
                zaposlenik.MdiParent = this.MdiParent;
                zaposlenik.Show();
                Close();
            }
        }

        private void tboxZapIme_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(tboxZapIme);
        }

        private void tboxZapIme_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(tboxZapIme);
        }
      

        private void tboxZapPrezime_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(tboxZapPrezime);
        }

        private void tboxZapPrezime_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(tboxZapPrezime);
        }

        private void tboxZapKorIme_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(tboxZapKorIme);
        }

        private void tboxZapKorIme_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(tboxZapKorIme);
        }

        private void tboxZapLozinka_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(tboxZapLozinka);
        }

        private void tboxZapLozinka_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(tboxZapLozinka);
        }

        private void tboxZapEmail_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(tboxZapEmail);
        }

        private void tboxZapEmail_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(tboxZapEmail);
        }

        private void tboxZapTelefon_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(tboxZapTelefon);
        }

        private void tboxZapTelefon_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(tboxZapTelefon);
        }
       

        private void btnDodajZaposlenika_MouseEnter(object sender, EventArgs e)
        {
            btnDodajZaposlenika.BackColor = Color.FromArgb(255, 51, 51);
            int x = btnDodajZaposlenika.Size.Width + 3;
            int y = btnDodajZaposlenika.Size.Height + 3;
            btnDodajZaposlenika.Size = new Size(x, y);
            btnDodajZaposlenika.Font = new System.Drawing.Font(btnDodajZaposlenika.Font.FontFamily.Name, 11, FontStyle.Bold);
        }

        private void btnDodajZaposlenika_MouseLeave(object sender, EventArgs e)
        {
            btnDodajZaposlenika.BackColor = Color.White;
            btnDodajZaposlenika.Size = new Size(226, 34);
            btnDodajZaposlenika.Font = new System.Drawing.Font(btnDodajZaposlenika.Font.FontFamily.Name, 10);
        }
        void PovecajOboji(TextBox s)
        {
            s.BackColor = Color.FromArgb(204, 255, 255);
            int x = s.Size.Width + 3;
            int y = s.Size.Height + 3;
            s.Size = new Size(x, y);
        }
        void VratiNaPocetnoStanje(TextBox s)
        {
            s.BackColor = Color.White;
            s.Size = new Size(226, 20);
        }
    }
}
