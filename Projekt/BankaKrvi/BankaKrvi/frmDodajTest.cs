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
    public partial class frmDodajTest : Form
    {
        private Pristup pristupTestu = Pristup.nista;
        private test t;
        private int odabraniTest;

        public frmDodajTest(Pristup PristupTestu_)
        {
            pristupTestu = PristupTestu_;
            InitializeComponent();
            this.CenterToParent();

            PostaviTestFormu();
        }

        public frmDodajTest(Pristup PristupTestu_, int odabrano)
        {
            pristupTestu = PristupTestu_;
            odabraniTest = odabrano;
            InitializeComponent();
            this.CenterToParent();

            PostaviTestFormu();
        }


        private void PostaviTestFormu()
        {
            if (pristupTestu == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj test";
                btnDntDodaj.Text = "Ažuriraj test";
            }
            else if (pristupTestu == Pristup.kreiraj)
            {
                this.Text = "Dodaj test";
                btnDntDodaj.Text = "Dodaj Test";
            }
        }

        
       
        private void frmDodajTest_Load(object sender, EventArgs e)
        {
            if (pristupTestu == Pristup.azuriraj)
            {
                DohvatiPodatke();
                using (var db = new bankakrviEntities())
                {
                    t = db.test.Where(x => x.testID.Equals(odabraniTest)).First();
                    cboxDntBolest.SelectedValue = t.test_bolestID;
                    cboxDntDonacija.SelectedValue = t.test_donacijaID;
                    ckbDntOdobren.Checked = (bool)t.odobren;
                    cboxDntUstanova.SelectedValue = t.test_ustanovaID;
                    dtpDntVrijeme.Value = DateTime.Parse(t.vrijeme.ToString());

                }

            }
            else if (pristupTestu == Pristup.kreiraj)
            {
                DohvatiPodatke();
            }
        }

        public void DohvatiPodatke() 
        {
            using (var db = new bankakrviEntities())
            {

                cboxDntUstanova.DataSource = db.ustanova.ToList();
                cboxDntUstanova.ValueMember = "ustanovaID";
                cboxDntUstanova.DisplayMember = "naziv";

                cboxDntBolest.DataSource = db.bolest.ToList();
                cboxDntBolest.ValueMember = "bolestID";
                cboxDntBolest.DisplayMember = "naziv";

                cboxDntDonacija.DataSource = db.donacija.ToList();
                cboxDntDonacija.ValueMember = "donacijaID";
                cboxDntDonacija.DisplayMember = "donacijaID";


            }
        }

        private void btnDntDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities())
            {

                if (pristupTestu == Pristup.kreiraj)
                {
                    t = new test();
                }
                else if (pristupTestu == Pristup.azuriraj)
                {
                    db.test.Attach(t);
                }

                t.odobren = ckbDntOdobren.Checked;
                t.vrijeme = DateTime.Parse(dtpDntVrijeme.Value.ToString());
                t.test_bolestID = Convert.ToInt32(cboxDntBolest.SelectedValue);
                t.test_donacijaID = Convert.ToInt32(cboxDntDonacija.SelectedValue);
                t.test_ustanovaID = Convert.ToInt32(cboxDntUstanova.SelectedValue);


                if (pristupTestu == Pristup.kreiraj)
                {
                    db.test.Add(t);
                }

                db.SaveChanges();

                if (pristupTestu == Pristup.kreiraj)
                {
                    MessageBox.Show("Uspješno ste dodali test");
                }
                else if (pristupTestu == Pristup.azuriraj)
                {
                    MessageBox.Show("Uspješno ste azurirali test");
                }

                Close();
            }
        }
    }
}
