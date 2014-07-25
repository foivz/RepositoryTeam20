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
        private Boolean noviZapis;
        private hladnjak h;

        public frmDodavanjeHladnjaka()
        {
            InitializeComponent();
            txtId.Text = "Novi unos";
            dohvatiKrvneGrupe();
            noviZapis = true;
        }

        public frmDodavanjeHladnjaka(int selektirani)
        {
            InitializeComponent();
            this.Text = "Uređivanje zapisa";
            dohvatiKrvneGrupe();
            using (var db = new bankakrviEntities())
            {
                h = db.hladnjak.Where(x => x.hladnjakID.Equals(selektirani)).First();
                txtId.Text = h.hladnjakID.ToString();
                txtNaziv.Text = h.naziv;
                cbPun.Checked = (bool)h.pun;
                cboxKrvnaGrupa.SelectedValue = h.hladnjak_krvnaGrupaID;
            }
            noviZapis = false;
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
                if (noviZapis)
                {
                    h = new hladnjak();
                }
                else
                {
                    db.hladnjak.Attach(h);
                }
                h.naziv = txtNaziv.Text;
                h.pun = cbPun.Checked;
                h.hladnjak_krvnaGrupaID = Convert.ToInt32(cboxKrvnaGrupa.SelectedValue);
                if (noviZapis)
                {
                    db.hladnjak.Add(h);
                }
                db.SaveChanges();
            }
            frmPregledHladnjaka hladnjaci = new frmPregledHladnjaka();
            hladnjaci.MdiParent = this.MdiParent;
            hladnjaci.Show();
            this.Close();
        }

        private void btnSpremi_MouseEnter(object sender, EventArgs e)
        {
            btnSpremi.BackColor = Color.FromArgb(255, 51, 51);
            int x = btnSpremi.Size.Width + 3;
            int y = btnSpremi.Size.Height + 3;
            btnSpremi.Size = new Size(x, y);
            btnSpremi.Font = new System.Drawing.Font(btnSpremi.Font.FontFamily.Name, 11, FontStyle.Bold);
        }

        private void btnSpremi_MouseLeave(object sender, EventArgs e)
        {
            btnSpremi.BackColor = Color.White;
            btnSpremi.Size = new Size(121, 28);
            btnSpremi.Font = new System.Drawing.Font(btnSpremi.Font.FontFamily.Name, 10);
        }

        private void txtNaziv_MouseEnter(object sender, EventArgs e)
        {
            txtNaziv.BackColor = Color.FromArgb(204, 255, 255);
            int x = txtNaziv.Size.Width + 3;
            int y = txtNaziv.Size.Height + 3;
            txtNaziv.Size = new Size(x, y);
        }

        private void txtNaziv_MouseLeave(object sender, EventArgs e)
        {
            txtNaziv.BackColor = Color.White;
            txtNaziv.Size = new Size(121, 20);
        }
      
    }
}
