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
                btnDodajZaposlenika.Text = "Ažuriraj zaposlenika";
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
    }
}
