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
       

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            PovecajObojiTextbox(textBox1);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanjeTextbox(textBox1);
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            PovecajObojiTextbox(textBox2);
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanjeTextbox(textBox2);
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {           
            PovecajObojiTextbox(textBox3);
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanjeTextbox(textBox3);
        }

        private void btnDodajTransfuziju_MouseEnter(object sender, EventArgs e)
        {           
            PovecajObojiButton(btnDodajTransfuziju);
        }

        private void btnDodajTransfuziju_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanjeButton(btnDodajTransfuziju);
        }      

        private void btnDodajDonaciju_MouseEnter(object sender, EventArgs e)
        {
            PovecajObojiButton(btnDodajDonaciju);
        }

        private void btnDodajDonaciju_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanjeButton(btnDodajDonaciju);
        }

        private void btnDodajReakciju_MouseEnter(object sender, EventArgs e)
        {
            PovecajObojiButton(btnDodajReakciju);
        }

        private void btnDodajReakciju_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanjeButton(btnDodajReakciju);
        }
        void PovecajObojiTextbox(TextBox s)
        {
            s.BackColor = Color.FromArgb(204, 255, 255);
            int x = s.Size.Width + 3;
            int y = s.Size.Height + 3;
            s.Size = new Size(x, y);
        }
        void VratiNaPocetnoStanjeTextbox(TextBox s)
        {
            s.BackColor = Color.White;
            if (textBox1 == s)
            {
                s.Size = new Size(236, 80);
            }
            else
            {
                s.Size = new Size(116, 20);
            }
        }
        void PovecajObojiButton(Button b)
        {
            b.BackColor = Color.FromArgb(255, 51, 51);
            int x = b.Size.Width + 3;
            int y = b.Size.Height + 3;
            b.Size = new Size(x, y);
            b.Font = new System.Drawing.Font(b.Font.FontFamily.Name, 11, FontStyle.Bold);
        }
        void VratiNaPocetnoStanjeButton(Button b)
        {
            b.BackColor = Color.White;
            b.Size = new Size(149, 46);
            b.Font = new System.Drawing.Font(b.Font.FontFamily.Name, 10);
        }
    }
}
