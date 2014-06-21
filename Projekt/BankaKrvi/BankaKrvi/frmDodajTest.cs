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

        public frmDodajTest(Pristup PristupTestu_)
        {
            pristupTestu = PristupTestu_;
            InitializeComponent();
            this.CenterToParent();

            PostaviTestFormu();
        }

        /// <summary>
        /// Poslije samo ne zaboraviti ako je ažuriranje da učitaš podatke o testu iz baze
        /// Kad si u prethodnoj formi odabrao test koji zelis azurirati, posalji id njega, ili postavi preko metode, i onda u ovoj funkciji
        /// ovisno o tipu pristupa ( Pristup.azuriraj ) dohvati na temelju tog id-a podatke o tom testu i zaljepi ih na inpute
        /// </summary>
        private void PostaviTestFormu()
        {
            if (pristupTestu == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj test";
            }
            else if (pristupTestu == Pristup.kreiraj)
            {
                this.Text = "Dodaj test";
            }
        }

        
       
        private void frmDodajTest_Load(object sender, EventArgs e)
        {
            if (pristupTestu == Pristup.azuriraj)
            {
                //todo ucitaj podatke testa

            }
            else if (pristupTestu == Pristup.kreiraj)
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
        }

        private void btnDntDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities()) 
            {   
                bool odobren1 = false;
                if (cboxDntOdobren.Text == "DA")
                {
                    odobren1 = true;
                }
               
                test noviTest = new test
                {  
                    
                    odobren = odobren1, 
                    vrijeme = DateTime.Parse(dtpDntVrijeme.Value.ToString("yyyy-MM-dd hh:mm:ss")),
                    test_ustanovaID =  Convert.ToInt32(cboxDntUstanova.SelectedValue),
                    test_bolestID = Convert.ToInt32(cboxDntBolest.SelectedValue),
                    test_donacijaID = Convert.ToInt32(cboxDntDonacija.SelectedValue)

                   
                };
                db.test.Add(noviTest);
                db.SaveChanges();
            }
            MessageBox.Show("Uspiješno ste dodali test");
            Close();
        }

        
    }
}
