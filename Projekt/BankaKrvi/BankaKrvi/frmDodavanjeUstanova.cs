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
        public frmDodavanjeUstanova(Pristup PristupUstanovama_)
        {
            pristupUstanovi = PristupUstanovama_;

            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }
        private void PostaviFormu()
        {
            if (pristupUstanovi == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj podatke ustanove";

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
                //todo ucitaj podatke pacijenta

            }
 
        }

        private void btnDodajUstanovu_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities())
            {
                ustanova novaUstanova = new ustanova
                {
                    naziv = textBox1.Text,
                    adresa = textBox2.Text,
                    email = textBox3.Text,
                    telefon = textBox4.Text
                };
                db.ustanova.Add(novaUstanova);
                db.SaveChanges();
            }
            MessageBox.Show("Uspješno ste dodali ustanovu");
            Close();
        }
    }
}
