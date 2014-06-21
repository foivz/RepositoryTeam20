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
    public partial class frmPregledReakcija : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();
        public frmPregledReakcija()
        {
            InitializeComponent();
        }

        private void PrikaziReakcije()
        {
            BindingSource bsPregledReakcija = new BindingSource();
            bsPregledReakcija.DataSource = (from r in ctx.tipptreakcije
                                           select new { r.naziv }).ToList();



            dgvReakcije.DataSource = bsPregledReakcija;

        }

        private void frmPregledReakcija_Load(object sender, EventArgs e)
        {
            PrikaziReakcije();

        }
    }
}
