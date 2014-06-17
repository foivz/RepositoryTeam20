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
    }
}
