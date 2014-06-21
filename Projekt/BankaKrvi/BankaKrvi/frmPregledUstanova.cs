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
    public partial class frmPregledUstanova : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();

        public frmPregledUstanova()
        {
            InitializeComponent();
        }

        private void PrikaziUstanove()
        {
            BindingSource bsPregledUstanova = new BindingSource();
            bsPregledUstanova.DataSource = (from u in ctx.ustanova
                                            select new { u.naziv, u.adresa, u.email, u.telefon }).ToList();



            dgvUstanove.DataSource = bsPregledUstanova;

        }

        private void frmPregledUstanova_Load(object sender, EventArgs e)
        {
            PrikaziUstanove();
        }
    }
}
