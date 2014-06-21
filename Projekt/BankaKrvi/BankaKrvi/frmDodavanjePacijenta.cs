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
        private pacijent p;
        private int odabraniPacijent;

        public frmDodavanjePacijenta(Pristup PristupPacijentima_)
        {
            pristupPacijentu = PristupPacijentima_;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        public frmDodavanjePacijenta(Pristup PristupPacijentima_, int odabrano)
        {
            pristupPacijentu = PristupPacijentima_;
            odabraniPacijent = odabrano;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        private void PostaviFormu()
        {
            if (pristupPacijentu == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj podatke pacijenta";
                btnDnpDodaj.Text = "Ažuriraj pacijenta";
                
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
                DohvatiPodatke();
                using (var db = new bankakrviEntities())
                {
                    p = db.pacijent.Where(x => x.pacijentID.Equals(odabraniPacijent)).First();
                    txbDnpOIB.Text = p.OIB;
                    txbDnpIme.Text = p.ime;
                    txbDnpPrezime.Text = p.prezime;
                    txbDnpAdresa.Text = p.adresa;
                    txbDnpTelefon.Text = p.telefon;
                    txbDnpEmail.Text = p.email;
                    txbDnpPolicaOsiguranja.Text = p.brojPoliceOsiguranja;
                    dtpDnpDatumRodenja.Value = DateTime.Parse(p.datum_rodenja.ToString());
                    txbDnpTezina.Text = p.tezina;
                    cboxDnpKrvnaGrupa.SelectedValue = p.pacijent_krvnaGrupaID;
                    cboxDnpSpol.SelectedValue = p.pacijent_spolID;
                    cboxDnpTip.SelectedValue = p.pacijent_tipPacijentaID;
                }
            }
            else if (pristupPacijentu == Pristup.kreiraj)
            {
                DohvatiPodatke();
            }
            

        }
        private void DohvatiPodatke() 
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
        
        private void btnDnpDodaj_Click(object sender, EventArgs e)
        {
            

                using (var db = new bankakrviEntities())
                {
                    if (pristupPacijentu == Pristup.kreiraj)
                    {
                        p = new pacijent();    
                    }
                    else if (pristupPacijentu == Pristup.azuriraj)
                    {
                        db.pacijent.Attach(p);    
                    }
                   

                        p.OIB = txbDnpOIB.Text;
                        p.ime = txbDnpIme.Text;
                        p.prezime = txbDnpPrezime.Text;
                        p.adresa = txbDnpAdresa.Text;
                        p.brojPoliceOsiguranja = txbDnpPolicaOsiguranja.Text;
                        p.telefon = txbDnpTelefon.Text;
                        p.email = txbDnpEmail.Text;
                        p.tezina = txbDnpTezina.Text;
                        p.datum_rodenja = DateTime.Parse(dtpDnpDatumRodenja.Value.ToString("yyyy-MM-dd"));
                        p.pacijent_krvnaGrupaID = Convert.ToInt32(cboxDnpKrvnaGrupa.SelectedValue);
                        p.pacijent_tipPacijentaID = Convert.ToInt32(cboxDnpTip.SelectedValue);
                        p.pacijent_spolID = Convert.ToInt32(cboxDnpSpol.SelectedValue);

                        if (pristupPacijentu == Pristup.kreiraj)
                        {
                            db.pacijent.Add(p);
                        }
                    
                    
                    db.SaveChanges();
                    if (pristupPacijentu == Pristup.kreiraj)
                    {
                        MessageBox.Show("Uspješno ste dodali pacijenta");
                    }
                    else if (pristupPacijentu == Pristup.azuriraj)
                    {
                        MessageBox.Show("Uspješno ste azurirali");
                    }
                    
                
                
                Close();
            }
        }
        
    }
}