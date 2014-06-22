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
    public partial class frmDodavanjeBolesti : Form
    {
        private Pristup pristupBolesti = Pristup.nista;
        private bolest b;
        private int odabranaBolest;

        public frmDodavanjeBolesti(Pristup PristupBolesti_)
        {
            pristupBolesti = PristupBolesti_;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        public frmDodavanjeBolesti(Pristup PristupBolesti_, int odabrano)
        {
            pristupBolesti = PristupBolesti_;
            odabranaBolest = odabrano;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        private void PostaviFormu()
        {
            if (pristupBolesti == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj podatke bolesti";
                btnDodajBolest.Text = "Ažuriraj bolest";

            }
            else if (pristupBolesti == Pristup.kreiraj)
            {
                this.Text = "Dodaj novu bolest";
            }
        }

        private void frmDodavanjeBolesti_Load(object sender, EventArgs e)
        {
            if (pristupBolesti == Pristup.azuriraj)
            {
                using (var db = new bankakrviEntities())
                {
                    b = db.bolest.Where(x => x.bolestID.Equals(odabranaBolest)).First();
                    txtDnbNaziv.Text = b.naziv;
                }

            }
            else if (pristupBolesti == Pristup.azuriraj)
            {

            }
        }

        private void btnDodajBolest_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities())
            {
                if (pristupBolesti == Pristup.kreiraj)
                {
                    b = new bolest();
                }
                else if (pristupBolesti == Pristup.azuriraj)
                {
                    db.bolest.Attach(b);
                }

                b.naziv = txtDnbNaziv.Text;

                if (pristupBolesti == Pristup.kreiraj)
                {
                    db.bolest.Add(b);
                }

                db.SaveChanges();

                if (pristupBolesti == Pristup.kreiraj)
                {
                    MessageBox.Show("Uspješno ste dodali bolest");
                }
                else if (pristupBolesti == Pristup.azuriraj)
                {

                    MessageBox.Show("Uspješno ste azurirali");
                }


                frmPregledBolesti ustanova = new frmPregledBolesti();
                ustanova.MdiParent = this.MdiParent;
                ustanova.Show();
                Close();
            }
        }
    }
}
