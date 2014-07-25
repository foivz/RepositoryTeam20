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
      
        private void btnAzuriraj_MouseEnter(object sender, EventArgs e)
        {
            PovecajObojiButton(btnAzuriraj);
        }

        private void btnAzuriraj_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanjeButton(btnAzuriraj);
        }

        private void btnTemperaturaHladnjaka_MouseEnter(object sender, EventArgs e)
        {
            PovecajObojiButton(btnTemperaturaHladnjaka);
        }

        private void btnTemperaturaHladnjaka_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanjeButton(btnTemperaturaHladnjaka);
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
            b.Size = new Size(190, 34);
            b.Font = new System.Drawing.Font(b.Font.FontFamily.Name, 10);
        }

    }
}
