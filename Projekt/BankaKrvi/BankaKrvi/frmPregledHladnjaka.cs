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
    public partial class frmPregledHladnjaka : Form
    {
        public frmPregledHladnjaka()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void frmPregledHladnjaka_Load(object sender, EventArgs e)
        {
            BindingSource bsPregledHladnjaka = new BindingSource();
            using (var db = new bankakrviEntities())
            {
                bsPregledHladnjaka.DataSource = (from h in db.hladnjak
                                                 join k in db.krvnagrupa on h.hladnjak_krvnaGrupaID equals k.krvnaGrupaID
                                                 select new { h.hladnjakID, h.naziv, h.pun, krvnagrupa = k.naziv }).ToList();
            }
            dgvHladnjaci.DataSource = bsPregledHladnjaka;
        }

        

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int selektirani = int.Parse(dgvHladnjaci.CurrentRow.Cells[0].Value.ToString());
            frmDodavanjeHladnjaka dodajHladnjak = new frmDodavanjeHladnjaka(selektirani);
            dodajHladnjak.MdiParent = this.MdiParent;
            dodajHladnjak.Show();
            this.Close();
        }

        private void btnTemperaturaHladnjaka_Click(object sender, EventArgs e)
        {
            frmTemperaturaHladnjaka tempHladnjaka = new frmTemperaturaHladnjaka();
            tempHladnjaka.MdiParent = this.MdiParent;
            tempHladnjaka.Show();
        }


    }
}
