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
        bankakrviEntities ctx = new bankakrviEntities();

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
        private void PrikaziDonacije()
        {
            BindingSource bsPregledDonacija = new BindingSource();
            bsPregledDonacija.DataSource = (from d in ctx.donacija
                                               join p in ctx.pacijent on d.donacija_pacijentID equals p.pacijentID
                                               join h in ctx.hladnjak on d.donacija_hladnjakID equals h.hladnjakID
                                            select new {d.donacijaID, p.ime, p.prezime, p.datum_rodenja, d.napomena, d.kolicina, h.naziv}).ToList();


            dgvDonacije.DataSource = bsPregledDonacija;

        }

        private void PrikaziReakcije()
        {
            BindingSource bsPregledReakcija = new BindingSource();
            bsPregledReakcija.DataSource = (from r in ctx.tipptreakcije   select new { r.naziv }).ToList();


            dgvReakcije.DataSource = bsPregledReakcija;

        }
        private void frmDodavanjeTransfuzije_Load(object sender, EventArgs e)
        {
            PrikaziDonacije();
            PrikaziReakcije();           
        }
    }
}
