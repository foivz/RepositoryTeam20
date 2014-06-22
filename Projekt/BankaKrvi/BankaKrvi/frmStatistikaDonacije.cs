using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleChartSharp;

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

            var upit = (from p in ctx.pacijent
                       join d in ctx.donacija on p.pacijentID equals d.donacija_pacijentID
                       join k in ctx.krvnagrupa on p.pacijent_krvnaGrupaID equals k.krvnaGrupaID
                       group p by new { k.naziv } into g
                       select g.Count()).ToList();

            int[] vrijednosti = new int[8];
            int br = 0;
            foreach(var s in upit)
            {
                //MessageBox.Show("---"+s.ToString());
                vrijednosti[br] = Convert.ToInt32(s);
                br++;
                //MessageBox.Show(br+ " - "+ vrijednosti[br].ToString());
            }


            List<int[]> datasets = new List<int[]>();
            datasets.Add(vrijednosti);
            ChartAxis bottomAxis = new ChartAxis(ChartAxisType.Bottom, new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
            ChartAxis leftAxis = new ChartAxis(ChartAxisType.Left);
            leftAxis.SetRange(0, 50);
            BarChart barChart = new BarChart(400, 200, BarChartOrientation.Vertical, BarChartStyle.Grouped);
            barChart.SetTitle("Donacije po krvnim grupama");
            barChart.AddAxis(bottomAxis);
            barChart.AddAxis(leftAxis);
            barChart.SetData(datasets);

            barChart.SetDatasetColors(new string[] { "FF0000" });
            webBrowser1.Navigate(barChart.GetUrl());
            
        }

        
    } 
}
