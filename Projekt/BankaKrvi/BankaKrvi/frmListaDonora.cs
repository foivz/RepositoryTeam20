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
    public partial class frmListaDonora : Form
    {
        public frmListaDonora()
        {
            InitializeComponent();
        }

        private void frmListaDonora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ListaDonoraDataset.listadonora' table. You can move, or remove it, as needed.
            this.listadonoraTableAdapter.Fill(this.ListaDonoraDataset.listadonora);

            this.reportViewer1.RefreshReport();
        }
    }
}
