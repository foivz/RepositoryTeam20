using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                this.Text = "Ažuriraj podatke pacijenta";
                
            }
            else if (pristupPacijentu == Pristup.kreiraj)
            {
                this.Text = "Dodaj novog pacijenta";
            }
        }

        private void frmDodavanjePacijenta_Load(object sender, EventArgs e)
        {
            if (pristupPacijentu == Pristup.azuriraj)
            {
               //todo ucitaj podatke pacijenta

            }
            else if (pristupPacijentu == Pristup.kreiraj)
            {
                using (var db = new bankakrviEntities())
                {
                    cboxDnpKrvnaGrupa.DataSource = db.krvnagrupa.ToList();
                    cboxDnpKrvnaGrupa.ValueMember = "krvnaGrupaID";
                    cboxDnpKrvnaGrupa.DisplayMember = "naziv";

                    cboxDnpSpol.DataSource = db.spol.ToList();
                    cboxDnpSpol.ValueMember = "spolID";
                    cboxDnpSpol.DisplayMember = "naziv";

                    cboxDnpTip.DataSource = db.tippacijenta.ToList();
                    cboxDnpTip.ValueMember = "tipkorisnikaID";
                    cboxDnpTip.DisplayMember = "naziv";
                }
            }
            

        }
        
        private void btnDnpDodaj_Click(object sender, EventArgs e)
        {
   
            using (var db = new bankakrviEntities()) 
            {

                pacijent noviPacijent = new pacijent
                {  
                    
                    OIB = txbDnpOIB.Text,
                    ime = txbDnpIme.Text,
                    prezime = txbDnpPrezime.Text,
                    adresa = txbDnpAdresa.Text,
                    brojPoliceOsiguranja = txbDnpPolicaOsiguranja.Text,
                    telefon = txbDnpTelefon.Text,
                    email = txbDnpEmail.Text,
                    tezina = txbDnpTezina.Text,
                    datum_rodenja = DateTime.Parse(dtpDnpDatumRodenja.Value.ToString("yyyy-MM-dd")),
                    pacijent_krvnaGrupaID = Convert.ToInt32(cboxDnpKrvnaGrupa.SelectedValue),
                    pacijent_tipPacijentaID = Convert.ToInt32(cboxDnpTip.SelectedValue),
                    pacijent_spolID = Convert.ToInt32(cboxDnpSpol.SelectedValue)
                };
                db.pacijent.Add(noviPacijent);
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno ste dodali pacijenta");
            Close();
        }
        
    }
}