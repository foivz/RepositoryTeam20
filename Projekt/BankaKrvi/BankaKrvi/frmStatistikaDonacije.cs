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
    public partial class frmStatistikaDonacije : Form
    {
        bankakrviEntities ctx = new bankakrviEntities();
        public frmStatistikaDonacije()
        {
            InitializeComponent();
        }

        private void PrikaziDonacije() 
        {
            BindingSource bsPregledDinacija = new BindingSource();
            bsPregledDinacija.DataSource = (from p in ctx.pacijent
                                            join d in ctx.donacija on p.pacijentID equals d.donacija_pacijentID
                                            join k in ctx.krvnagrupa on p.pacijent_krvnaGrupaID equals k.krvnaGrupaID
                                            group p by new { p.pacijentID, p.ime, p.OIB, p.brojPoliceOsiguranja, p.prezime, p.datum_rodenja, k.naziv, d.donacija_pacijentID } into g
                                            select new { g.Key.pacijentID, g.Key.OIB, g.Key.ime, g.Key.prezime, g.Key.brojPoliceOsiguranja, g.Key.datum_rodenja, krvnaGrupa = g.Key.naziv, donacija = g.Count() }).ToList();


            
            dgvStatistikaDonacija.DataSource = bsPregledDinacija;
            
        }

        private void frmStatistikaDonacije_Load(object sender, EventArgs e)
        {
            PrikaziDonacije(); 
            
        }

        
    }
}
