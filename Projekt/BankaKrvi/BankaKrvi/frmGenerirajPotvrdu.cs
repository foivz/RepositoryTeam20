using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace BankaKrvi
{
    public partial class frmGenerirajPotvrdu : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();
        public frmGenerirajPotvrdu()
        {
            InitializeComponent();
        }
        private void PrikaziPacijente()
        {
            BindingSource bsPregledPacijenata = new BindingSource();
            bsPregledPacijenata.DataSource = (from p in ctx.pacijent
                                              join d in ctx.donacija on p.pacijentID equals d.donacija_pacijentID
                                              join k in ctx.krvnagrupa on p.pacijent_krvnaGrupaID equals k.krvnaGrupaID
                                              group p by new { p.pacijentID, p.ime, p.OIB, p.brojPoliceOsiguranja, p.prezime, p.datum_rodenja, k.naziv, d.donacija_pacijentID, d.vrijeme } into g
                                              select new { g.Key.pacijentID, g.Key.OIB, g.Key.ime, g.Key.prezime, g.Key.brojPoliceOsiguranja, g.Key.datum_rodenja, krvnaGrupa = g.Key.naziv, donacija = g.Key.vrijeme }).ToList();



            dgvPregled.DataSource = bsPregledPacijenata;

        }

        private void frmGenerirajPotvrdu_Load(object sender, EventArgs e)
        {
            PrikaziPacijente();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            int odabrano = Convert.ToInt32(dgvPregled.CurrentRow.Cells[0].Value.ToString());
            string ime = dgvPregled.CurrentRow.Cells[2].Value.ToString();
            string prezime = dgvPregled.CurrentRow.Cells[3].Value.ToString();
            string vrijeme = dgvPregled.CurrentRow.Cells[7].Value.ToString();

            Generiraj(ime, prezime, vrijeme);
            MessageBox.Show("Uspješno ste generirali potvrdu za donatora " + ime + " " + prezime + ".\nPotvrda se nalazi u direktoriju aplikacije Dokumenti.");
        }
        
        public static void Generiraj(string ime, string prezime, string vrijeme)
        {
            MessageBox.Show(ime + prezime + vrijeme);
            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            Font fontText = new Font(bfTimes, 12);
            Font fontHeadings = new Font(bfTimes, 16);
            if (!System.IO.Directory.Exists("./Dokumenti"))
            {
                System.IO.Directory.CreateDirectory("./Dokumenti");
            }

            Document potvrda = new Document(iTextSharp.text.PageSize.A4);
            System.IO.FileStream fs = new FileStream("Dokumenti/" + prezime.ToString() +ime.ToString()+".pdf", FileMode.Create);
            PdfWriter pdfWriter = PdfWriter.GetInstance(potvrda, fs);

            potvrda.Open();
            Paragraph Naslov = new Paragraph("POTRVRDA O DOBROVOLJNOM DARIVANJU KRVI \n------------------------------------------------------------------------\n\n\n", fontHeadings);
            potvrda.Add(Naslov);

            Paragraph Tekst = new Paragraph("Osoba " + ime + " " + prezime + " je dana " + vrijeme + " pristupila dobrovoljnom darivanju krvi\ni sukladno Čalnku 65. Zakona o radu ostvaruje pravo na jedan slobodan dan,\na ostvaruje ga u tijeku kalendarske godine sukladno radnim obvezama.\n\n\n Zaposlenik banke krvi " + Sesija.ime + " " + Sesija.prezime + "\n__________________ ", fontText);
            potvrda.Add(Tekst);

            potvrda.Close();
        }
    }
}
