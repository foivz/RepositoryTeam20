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
    public partial class frmPregledDonacija : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();
        public frmPregledDonacija()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnDodajTest_Click(object sender, EventArgs e)
        {
            frmDodajTest DodajTest = new frmDodajTest(Pristup.kreiraj);
            this.Hide();
            DodajTest.ShowDialog();
            this.Show();
        }

        private void btnAzurirajTest_Click(object sender, EventArgs e)
        {
            if (dgvTestovi.CurrentRow.Cells[0].Value.ToString() != null)
            {
                int odabrano = Convert.ToInt32(dgvTestovi.CurrentRow.Cells[0].Value.ToString());
                frmDodajTest AzurirajTest = new frmDodajTest(Pristup.azuriraj, odabrano);
                this.Hide();
                AzurirajTest.ShowDialog();
                this.Show();
            }
            else {
                MessageBox.Show("Odaberite test");
            }
            
        }

        private void btnAzuriranjeDonacije_Click(object sender, EventArgs e)
        {
            int odabrano = Convert.ToInt32(dgvDonacije.CurrentRow.Cells[0].Value.ToString());
            frmDodavanjeDonacije AzurirajDonaciju = new frmDodavanjeDonacije(Pristup.azuriraj, odabrano);
            AzurirajDonaciju.MdiParent = this.MdiParent;
            AzurirajDonaciju.Show();
            this.Close();
        }

        private void PrikaziDonacije()
        {
            BindingSource bsPregledDonacija = new BindingSource();
            bsPregledDonacija.DataSource = (from d in ctx.donacija
                                              join p in ctx.pacijent on d.donacija_pacijentID equals p.pacijentID
                                              join h in ctx.hladnjak on d.donacija_hladnjakID equals h.hladnjakID
                                              join z in ctx.zaposlenik on d.donacija_zaposlenikID equals z.zaposlenikID
                                              select new { d.donacijaID, d.vrijeme, d.napomena, pacijent = p.ime +" "+ p.prezime, hladnjak = h.naziv, zaposlenik = z.ime +" "+ z.prezime}).ToList();



            dgvDonacije.DataSource = bsPregledDonacija;

        }

        private void PrikaziTestove(int brojTesta) 
        {
            int d = brojTesta + 1;
            BindingSource bsPregledDonacija = new BindingSource();
            bsPregledDonacija.DataSource = (from t in ctx.test
                                            join u in ctx.ustanova on t.test_ustanovaID equals u.ustanovaID
                                            join b in ctx.bolest on t.test_bolestID equals b.bolestID
                                            where t.test_donacijaID == d
                                            select new { t.testID, t.odobren, t.vrijeme, ustanova = u.naziv, bolest = b.naziv }).ToList();



            dgvTestovi.DataSource = bsPregledDonacija;
            
        }

        private void frmPregledDonacija_Load(object sender, EventArgs e)
        {
            PrikaziDonacije();
            
        }

        private void dgvDonacije_SelectionChanged(object sender, EventArgs e)
        {
            int brojTesta = Convert.ToInt16(dgvDonacije.CurrentRow.Index);
            PrikaziTestove(brojTesta);
        }

        private void btnDodajTest_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(btnDodajTest);
        }

        private void btnDodajTest_MouseLeave(object sender, EventArgs e)
        {          
            VratiNaPocetnoStanje(btnDodajTest);
        }

        private void btnAzurirajTest_MouseEnter(object sender, EventArgs e)
        {          
            PovecajOboji(btnAzurirajTest);
        }

        private void btnAzurirajTest_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(btnAzurirajTest);
        }

        private void btnAzuriranjeDonacije_MouseEnter(object sender, EventArgs e)
        {
            PovecajOboji(btnAzuriranjeDonacije);
        }

        private void btnAzuriranjeDonacije_MouseLeave(object sender, EventArgs e)
        {
            VratiNaPocetnoStanje(btnAzuriranjeDonacije);
        }

        void PovecajOboji(Button s)
        {            
            s.BackColor = Color.FromArgb(255, 51, 51);
            int x = s.Size.Width + 3;
            int y = s.Size.Height + 3;
            s.Size = new Size(x, y);
            s.Font = new System.Drawing.Font(s.Font.FontFamily.Name, 11, FontStyle.Bold);
        }
        void VratiNaPocetnoStanje(Button s)
        {
            s.BackColor = Color.White;
            s.Size = new Size(186, 33);
            s.Font = new System.Drawing.Font(s.Font.FontFamily.Name, 10);
        }

      
    }
}
