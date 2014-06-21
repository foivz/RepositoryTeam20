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
    public partial class frmDodavanjeHladnjaka : Form
    {
        public frmDodavanjeHladnjaka()
        {
            InitializeComponent();
            txtId.Text = "Novi unos";
            dohvatiKrvneGrupe();
        }


        private void dohvatiKrvneGrupe()
        {
            using (var db = new bankakrviEntities())
            {
                cboxKrvnaGrupa.DataSource = db.krvnagrupa.ToList();
                cboxKrvnaGrupa.ValueMember = "krvnaGrupaID";
                cboxKrvnaGrupa.DisplayMember = "naziv";
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new bankakrviEntities())
            {
                hladnjak hladnjak = new hladnjak();
                hladnjak.naziv = txtNaziv.Text;
                hladnjak.pun = cbPun.Checked;
                hladnjak.hladnjak_krvnaGrupaID = Convert.ToInt32(cboxKrvnaGrupa.SelectedValue);
                db.hladnjak.Add(hladnjak);
                db.SaveChanges();
            }
            frmPregledHladnjaka hladnjaci = new frmPregledHladnjaka();
            hladnjaci.MdiParent = this.MdiParent;
            hladnjaci.Show();
            this.Close();
        }
    }
}
