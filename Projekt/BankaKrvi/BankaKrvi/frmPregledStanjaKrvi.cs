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
    public partial class frmPregledStanjaKrvi : Form
    {
        public frmPregledStanjaKrvi()
        {
            InitializeComponent();
        }

        private void btnPosaljiMail_Click(object sender, EventArgs e)
        {
            DialogResult odabir = MessageBox.Show("Poslati ćete mail donatorima s krvnom grupom","Slanje maila",MessageBoxButtons.YesNo);

            if (odabir == DialogResult.Yes)
            {
                MessageBox.Show("Odabrali ste da","Odgovor");
            }
            else if (odabir == DialogResult.No)
            {
                MessageBox.Show("Odabrali ste ne","Odgovor");
            }
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
