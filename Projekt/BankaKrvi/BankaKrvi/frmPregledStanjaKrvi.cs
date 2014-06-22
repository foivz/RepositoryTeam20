using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace BankaKrvi
{
    public partial class frmPregledStanjaKrvi : Form
    {
        public frmPregledStanjaKrvi()
        {
            InitializeComponent();
        }

        private void btnPosaljiMail_Click(object sender, EventArgs e)
        {
            int selektirani = int.Parse(dgvZaliheKrvi.CurrentRow.Cells[0].Value.ToString());
            
            DialogResult odabir = MessageBox.Show("Poslati ćete mail donatorima s krvnom grupom", "Slanje maila", MessageBoxButtons.YesNo);
            if (odabir == DialogResult.Yes)
            {
                MessageBox.Show("Odabrali ste da", "Odgovor");
                using (var db = new bankakrviEntities())
                {
                    var pacijenti = db.pacijent.Where(x => x.pacijent_krvnaGrupaID == selektirani);
                    foreach (var p in pacijenti)
                    {
                        posaljiMail(p.email);
                    }
                }
            }
            else if (odabir == DialogResult.No)
            {
                MessageBox.Show("Odabrali ste ne", "Odgovor");
            }
        }

        private void posaljiMail(string email)
        {
            string Mail = "pi.krvnik@gmail.com";
            string Password = "mislavbago";
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(Mail, Password),
                EnableSsl = true
            };
            client.Send(Mail, email, "Banka krvi", "Molimo vas dajte svoju krv hitno!!!");
        }



        private void frmPregledStanjaKrvi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID grupe");
            dt.Columns.Add("Krvna grupa");
            dt.Columns.Add("Stanje");
            using (var db = new bankakrviEntities())
            {
                foreach (var krv in db.krvnagrupa)
                {
                    int count;
                    using (var temp = new bankakrviEntities())
                    {
                        count = (from p in temp.pacijent
                                 join d in temp.donacija on p.pacijentID equals d.donacija_pacijentID
                                 where p.pacijent_krvnaGrupaID == krv.krvnaGrupaID
                                 where d.transfuzija.Count == 0
                                 select new { p.pacijentID }).Count();
                    }
                    dt.Rows.Add(krv.krvnaGrupaID, krv.naziv, count);
                }
            }
            dgvZaliheKrvi.DataSource = dt;
        }
    }
}
