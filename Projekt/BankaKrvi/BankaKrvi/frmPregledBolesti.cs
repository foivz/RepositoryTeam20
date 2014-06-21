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
    public partial class frmPregledBolesti : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();
        public frmPregledBolesti()
        {
            InitializeComponent();
        }

        private void PrikaziBolesti()
        {
            BindingSource bsPregledBolesti = new BindingSource();
            bsPregledBolesti.DataSource = (from b in ctx.bolest
                                            select new { b.naziv }).ToList();



            dgvBolesti.DataSource = bsPregledBolesti;

        }

        private void frmPregledBolesti_Load(object sender, EventArgs e)
        {
            PrikaziBolesti();

        }
    }
}
