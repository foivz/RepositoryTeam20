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
    public partial class frmDodavanjeDonacije : Form
    {
        private Pristup pristupDonacijama = Pristup.nista;
        private donacija d;
        private int odabranaDonacija;

        public frmDodavanjeDonacije(Pristup pristupDonacijama_)
        {
            pristupDonacijama = pristupDonacijama_;
            InitializeComponent();
            this.CenterToParent();
            PostaviFormu();
        }

        public frmDodavanjeDonacije(Pristup PristupPacijentima_, int odabrano)
        {
            pristupDonacijama = PristupPacijentima_;
            odabranaDonacija = odabrano;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        private void PostaviFormu()
        {
            if (pristupDonacijama == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj podatke donacije";
                btnDndDodaj.Text = "Ažuriraj donacije";

            }
            else if (pristupDonacijama == Pristup.kreiraj)
            {
                this.Text = "Dodaj novou donaciju";
            }
        }

        private void frmDodavanjeDonacije_Load(object sender, EventArgs e)
        {
            if (pristupDonacijama == Pristup.azuriraj)
            {
                DohvatiPodatke();
                using (var db = new bankakrviEntities())
                {
                    d = db.donacija.Where(x => x.donacijaID.Equals(odabranaDonacija)).First();
                    dtpDndVrijeme.Value = DateTime.Parse(d.vrijeme.ToString());
                    txtDndNapomena.Text = d.napomena;
                    cboxDndHladnjak.SelectedValue = d.donacija_hladnjakID;
                    cboxDndPacijent.SelectedValue = d.donacija_pacijentID;
                    cboxDndZaposlenik.SelectedValue = d.donacija_zaposlenikID;

                }
            }
            else if (pristupDonacijama == Pristup.kreiraj)
            {
                DohvatiPodatke();
            }
        }
        private void DohvatiPodatke()
        {
            using (var db = new bankakrviEntities())
            {
                cboxDndHladnjak.DataSource = db.hladnjak.ToList();
                cboxDndHladnjak.ValueMember = "hladnjakID";
                cboxDndHladnjak.DisplayMember = "naziv";

                cboxDndPacijent.DataSource = db.pacijent.ToList();
                cboxDndPacijent.ValueMember = "pacijentID";
                cboxDndPacijent.DisplayMember = "ime" + "prezime";

                cboxDndZaposlenik.DataSource = db.zaposlenik.ToList();
                cboxDndZaposlenik.ValueMember = "zaposlenikID";
                cboxDndZaposlenik.DisplayMember = "naziv";
            }
        }

        private void btnDndDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities())
            {
                if (pristupDonacijama == Pristup.kreiraj)
                {
                    d = new donacija();
                }
                else if (pristupDonacijama == Pristup.azuriraj)
                {
                    db.donacija.Attach(d);
                }

                d.vrijeme = DateTime.Parse(dtpDndVrijeme.Value.ToString());
                d.napomena = txtDndNapomena.Text;
                d.donacija_pacijentID = Convert.ToInt32(cboxDndPacijent.SelectedValue);
                d.donacija_hladnjakID = Convert.ToInt32(cboxDndHladnjak.SelectedValue);
                d.donacija_zaposlenikID = Convert.ToInt32(cboxDndZaposlenik.SelectedValue);


                if (pristupDonacijama == Pristup.kreiraj)
                {
                    db.donacija.Add(d);
                }


                db.SaveChanges();
                if (pristupDonacijama == Pristup.kreiraj)
                {
                    MessageBox.Show("Uspješno ste dodali donaciju");
                }
                else if (pristupDonacijama == Pristup.azuriraj)
                {
                    MessageBox.Show("Uspješno ste azurirali");
                }


                frmPregledDonacija donacije = new frmPregledDonacija();
                donacije.MdiParent = this.MdiParent;
                donacije.Show();
                Close();
               
            }
        }

        private void txtDndNapomena_MouseEnter(object sender, EventArgs e)
        {
            txtDndNapomena.BackColor = Color.FromArgb(204, 255, 255);
            int x = txtDndNapomena.Size.Width + 3;
            int y = txtDndNapomena.Size.Height + 3;
            txtDndNapomena.Size = new Size(x, y);
        }

        private void txtDndNapomena_MouseLeave(object sender, EventArgs e)
        {
            txtDndNapomena.BackColor = Color.White;
            txtDndNapomena.Size = new Size(217, 58);
        }

        private void btnDndDodaj_MouseEnter(object sender, EventArgs e)
        {
            btnDndDodaj.BackColor = Color.FromArgb(255, 51, 51);
            int x = btnDndDodaj.Size.Width + 3;
            int y = btnDndDodaj.Size.Height + 3;
            btnDndDodaj.Size = new Size(x, y);
            btnDndDodaj.Font = new System.Drawing.Font(btnDndDodaj.Font.FontFamily.Name, 11, FontStyle.Bold);
        }

        private void btnDndDodaj_MouseLeave(object sender, EventArgs e)
        {
            btnDndDodaj.BackColor = Color.White;
            btnDndDodaj.Size = new Size(152, 34);
            btnDndDodaj.Font = new System.Drawing.Font(btnDndDodaj.Font.FontFamily.Name, 10);
        }
    }
}
