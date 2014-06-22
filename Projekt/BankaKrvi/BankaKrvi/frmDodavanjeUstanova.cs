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
    public partial class frmDodavanjeUstanova : Form
    {
        private Pristup pristupUstanovi = Pristup.nista;
        private ustanova u;
        private int odabranaUstanova;

        public frmDodavanjeUstanova(Pristup PristupUstanovama_)
        {
            pristupUstanovi = PristupUstanovama_;

            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        public frmDodavanjeUstanova(Pristup PristupUstanovama_, int odabrano)
        {
            pristupUstanovi = PristupUstanovama_;
            odabranaUstanova = odabrano;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        private void PostaviFormu()
        {
            if (pristupUstanovi == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj podatke ustanove";
                btnDodajUstanovu.Text = "Ažuriraj ustanovu";

            }
            else if (pristupUstanovi == Pristup.kreiraj)
            {
                this.Text = "Dodaj novu ustanovu";
            }
        }

        private void frmDodavanjeUstanova_Load(object sender, EventArgs e)
        {
            if (pristupUstanovi == Pristup.azuriraj)
            {
                using (var db = new bankakrviEntities())
                {
                    u = db.ustanova.Where(x => x.ustanovaID.Equals(odabranaUstanova)).First();
                    txtDnuNaziv.Text = u.naziv;
                    txtDnuAdresa.Text = u.adresa;
                    txtDnuEmail.Text = u.email;
                    txtDnuTelefon.Text = u.telefon;
                }

            }
            else if (pristupUstanovi == Pristup.azuriraj)
            { 
            
            }
 
        }

        private void btnDodajUstanovu_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities())
            {
                if (pristupUstanovi == Pristup.kreiraj)
                {
                    u = new ustanova();
                }
                else if (pristupUstanovi == Pristup.azuriraj)
                {
                    db.ustanova.Attach(u);
                }
                
                 u.naziv = txtDnuNaziv.Text;
                 u.adresa = txtDnuAdresa.Text;
                 u.email = txtDnuEmail.Text;
                 u.telefon = txtDnuTelefon.Text;

                 if (pristupUstanovi == Pristup.kreiraj)
                 {
                     db.ustanova.Add(u);
                 }

                 db.SaveChanges();

                 if (pristupUstanovi == Pristup.kreiraj)
                 {
                     MessageBox.Show("Uspješno ste dodali ustanovu");
                 }
                 else if (pristupUstanovi == Pristup.azuriraj)
                 {

                     MessageBox.Show("Uspješno ste azurirali");
                 }


                 frmPregledUstanova ustanova = new frmPregledUstanova();
                 ustanova.MdiParent = this.MdiParent;
                 ustanova.Show();
                 Close();
            }
        }
    }
}
