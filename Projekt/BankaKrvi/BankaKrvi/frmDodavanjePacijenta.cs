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

        private void btnDnpDodaj_MouseLeave(object sender, EventArgs e)
        {
            btnDnpDodaj.BackColor = Color.White;
            btnDnpDodaj.Size = new Size(232, 31);
            btnDnpDodaj.Font = new System.Drawing.Font(btnDnpDodaj.Font.FontFamily.Name, 10);
        }

      
        private void txbDnpOIB_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(txbDnpOIB);
        }
        
        private void txbDnpIme_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(txbDnpIme);
        }
       private void txbDnpPrezime_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(txbDnpPrezime);
        }   

        private void txbDnpAdresa_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(txbDnpAdresa);
        }

         private void txbDnpTelefon_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(txbDnpTelefon);
        }

     
        private void txbDnpEmail_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(txbDnpEmail);
        }

       
        private void txbDnpPolicaOsiguranja_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(txbDnpPolicaOsiguranja);
        }

      
        private void txbDnpTezina_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(txbDnpTezina);
        }

        private void txbDnpOIB_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(txbDnpOIB);
        }

        private void txbDnpIme_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(txbDnpIme);
        }

        private void txbDnpPrezime_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(txbDnpPrezime);
        }

        private void txbDnpAdresa_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(txbDnpAdresa);
        }

        private void txbDnpTelefon_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(txbDnpTelefon);
        }

        private void txbDnpEmail_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(txbDnpEmail);
        }

        private void txbDnpPolicaOsiguranja_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(txbDnpPolicaOsiguranja);
        }

        private void txbDnpTezina_MouseEnter(object sender, EventArgs e)
        {   
            PovecajOboji(txbDnpTezina);            
        }

        private void btnDnpDodaj_MouseEnter(object sender, EventArgs e)
        {
            btnDnpDodaj.BackColor = Color.FromArgb(255, 51, 51);
            int x = btnDnpDodaj.Size.Width + 3;
            int y = btnDnpDodaj.Size.Height + 3;
            btnDnpDodaj.Size = new Size(x, y);
            btnDnpDodaj.Font = new System.Drawing.Font(btnDnpDodaj.Font.FontFamily.Name, 11, FontStyle.Bold);
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
            s.Size = new Size(232, 20);
        }
    }
}