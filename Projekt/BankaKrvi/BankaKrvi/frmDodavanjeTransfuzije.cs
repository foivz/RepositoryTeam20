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
    public partial class frmDodavanjeTransfuzije : Form
    {
        private Pristup pristupTransfuziji = Pristup.nista;
        private transfuzija t;
        private int odabranaTransfuzija;

        public frmDodavanjeTransfuzije(Pristup PristupTransfuzijama_)
        {
            pristupTransfuziji = PristupTransfuzijama_;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        public frmDodavanjeTransfuzije(Pristup PristupTransfuzijama_, int odabrano)
        {
            pristupTransfuziji = PristupTransfuzijama_;
            odabranaTransfuzija = odabrano;
            InitializeComponent();
            this.CenterToParent();

            PostaviFormu();
        }

        private void PostaviFormu()
        {
            if (pristupTransfuziji == Pristup.azuriraj)
            {
                this.Text = "Ažuriraj podatke transfuzije";
                //btnDnpDodaj.Text = "Ažuriraj transfuziju";
                
            }
            else if (pristupTransfuziji == Pristup.kreiraj)
            {
                this.Text = "Dodaj novu transfuziju";
            }
        }
        public frmDodavanjeTransfuzije()
        {
            InitializeComponent();
        }
    }
}
