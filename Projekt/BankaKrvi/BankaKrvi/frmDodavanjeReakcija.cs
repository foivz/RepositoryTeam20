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
    public partial class frmDodavanjeReakcija : Form
    {
        private Pristup pristupReakciji = Pristup.nista;
        private tipptreakcije r;
        private int doabranaReakcija;

        public frmDodavanjeReakcija(Pristup PristupBolesti_)
        {
            pristupReakciji = PristupBolesti_;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        public frmDodavanjeReakcija(Pristup PristupBolesti_, int odabrano)
        {
            pristupReakciji = PristupBolesti_;
            doabranaReakcija = odabrano;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

          private void PostaviFormu()
        {
            if (pristupReakciji == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj podatke reakcije";
                btnDnrDodaj.Text = "Ažuriraj reakciju";

            }
            else if (pristupReakciji == Pristup.kreiraj)
            {
                this.Text = "Dodaj novu reakciju";
            }
        }

          private void frmDodavanjeReakcija_Load(object sender, EventArgs e)
          {
              if (pristupReakciji == Pristup.azuriraj)
              {
                  using (var db = new bankakrviEntities())
                  {
                      r = db.tipptreakcije.Where(x => x.tipPtReakcijeID.Equals(doabranaReakcija)).First();
                      txtDnrNaziv.Text = r.naziv;
                  }

              }
              else if (pristupReakciji == Pristup.azuriraj)
              {

              }
          }

        private void btnDnrDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities())
            {
                if (pristupReakciji == Pristup.kreiraj)
                {
                   r = new tipptreakcije();
                }
                else if (pristupReakciji == Pristup.azuriraj)
                {
                    db.tipptreakcije.Attach(r);
                }

                r.naziv = txtDnrNaziv.Text;

                if (pristupReakciji == Pristup.kreiraj)
                {
                    db.tipptreakcije.Add(r);
                }

                db.SaveChanges();

                if (pristupReakciji == Pristup.kreiraj)
                {
                    MessageBox.Show("Uspješno ste dodali bolest");
                }
                else if (pristupReakciji == Pristup.azuriraj)
                {

                    MessageBox.Show("Uspješno ste azurirali");
                }


                frmPregledReakcija reakcija = new frmPregledReakcija();
                reakcija.MdiParent = this.MdiParent;
                reakcija.Show();
                Close();
            }
        }

        private void txtDnrNaziv_MouseEnter(object sender, EventArgs e)
        {
            txtDnrNaziv.BackColor = Color.FromArgb(204, 255, 255);
            int x = txtDnrNaziv.Size.Width + 3;
            int y = txtDnrNaziv.Size.Height + 3;
            txtDnrNaziv.Size = new Size(x, y);
        }

        private void txtDnrNaziv_MouseLeave(object sender, EventArgs e)
        {
            txtDnrNaziv.BackColor = Color.White;
            txtDnrNaziv.Size = new Size(158, 20);
        }

        private void btnDnrDodaj_MouseEnter(object sender, EventArgs e)
        {
            btnDnrDodaj.BackColor = Color.FromArgb(255, 51, 51);
            int x = btnDnrDodaj.Size.Width + 3;
            int y = btnDnrDodaj.Size.Height + 3;
            btnDnrDodaj.Size = new Size(x, y);
            btnDnrDodaj.Font = new System.Drawing.Font(btnDnrDodaj.Font.FontFamily.Name, 11, FontStyle.Bold);
        }

        private void btnDnrDodaj_MouseLeave(object sender, EventArgs e)
        {
            btnDnrDodaj.BackColor = Color.White;
            btnDnrDodaj.Size = new Size(142, 34);
            btnDnrDodaj.Font = new System.Drawing.Font(btnDnrDodaj.Font.FontFamily.Name, 10);
        }

        
    }
}
