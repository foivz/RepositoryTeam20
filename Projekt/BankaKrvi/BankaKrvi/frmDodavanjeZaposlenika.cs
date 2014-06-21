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
        
        public frmDodavanjeZaposlenika(Pristup PristupZaposlenicima_)
        {
            
            pristupZaposleniku= PristupZaposlenicima_;

            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        
        }

        public frmDodavanjeZaposlenika()
        {
            // TODO: Complete member initialization
        }

        private void PostaviFormu()
        {
            if (pristupZaposleniku == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj podatke zaposlenika";

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
                //todo ucitaj podatke pacijenta

            }
            else if (pristupZaposleniku == Pristup.kreiraj)
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
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities())
            {

                zaposlenik noviZaposlenik = new zaposlenik
                {
                    ime = tboxZapIme.Text,
                    prezime = tboxZapPrezime.Text,
                    korisnickoIme = tboxZapKorIme.Text,
                    lozinka = tboxZapLozinka.Text,
                    email = tboxZapEmail.Text,
                    telefon = tboxZapTelefon.Text,
                    zaposlenik_tipZaposlenikaID = Convert.ToInt32(cboxZapTip.SelectedValue),
                    zaposlenik_ustanovaID = Convert.ToInt32(cboxZapUstanova.SelectedValue) 
                };
                db.zaposlenik.Add(noviZaposlenik);
                db.SaveChanges();
            }
            Close();
        }
    }
}
