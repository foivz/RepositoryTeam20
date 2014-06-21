using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graph = System.Windows.Forms.DataVisualization.Charting;

namespace BankaKrvi
{
    public partial class frmTemperaturaHladnjaka : Form
    {
        Graph.Chart chart;
        Control old = null;
        public frmTemperaturaHladnjaka()
        {
            InitializeComponent();
        }

        private void frmTemperaturaHladnjaka_Load(object sender, EventArgs e)
        {
            nacrtajGraf();
        }

        private void nacrtajGraf()
        {
            if (old != null)
            {
                Controls.Remove(old);
            }

            int intervalPrikaza = 15;

            // Create new Graph
            chart = new Graph.Chart();
            chart.Location = new System.Drawing.Point(10, 10);
            chart.Size = new System.Drawing.Size(700, 500);

            // Add a chartarea called "draw", add axes to it and color the area black
            chart.ChartAreas.Add("draw");

            //Dolje
            chart.ChartAreas["draw"].AxisX.Minimum = 1;
            chart.ChartAreas["draw"].AxisX.Maximum = intervalPrikaza;
            chart.ChartAreas["draw"].AxisX.Interval = 1;
            chart.ChartAreas["draw"].AxisX.MajorGrid.LineColor = Color.White;
            chart.ChartAreas["draw"].AxisX.MajorGrid.LineDashStyle = Graph.ChartDashStyle.Dash;

            //lijevo
            chart.ChartAreas["draw"].AxisY.Minimum = 0;
            chart.ChartAreas["draw"].AxisY.Maximum = 15;
            chart.ChartAreas["draw"].AxisY.Interval = 1;
            chart.ChartAreas["draw"].AxisY.MajorGrid.LineColor = Color.White;
            chart.ChartAreas["draw"].AxisY.MajorGrid.LineDashStyle = Graph.ChartDashStyle.Dash;

            chart.ChartAreas["draw"].BackColor = Color.Black;

            // Create a new function series
            chart.Series.Add("Temperatura");

            // Set the type to line      
            chart.Series["Temperatura"].ChartType = Graph.SeriesChartType.Line;

            // Color the line of the graph light green and give it a thickness of 3
            chart.Series["Temperatura"].Color = Color.LightGreen;
            chart.Series["Temperatura"].BorderWidth = 3;

            int start = 1;
            int end = frmBankaKrvi.podaciTemperatura.Count;
            if (end > intervalPrikaza)
            {
                start = end - intervalPrikaza;
            }
            for (int i = start; i <= end; i++)
            {
                int x = i - start + 1;
                chart.Series["Temperatura"].Points.AddXY(x, frmBankaKrvi.podaciTemperatura[i - 1]);
            }

            chart.Series["Temperatura"].LegendText = "Temperatura";

            // Create a new legend called "MyLegend".
            chart.Legends.Add("Legenda");
            chart.Legends["Legenda"].BorderColor = Color.Tomato; // I like tomato juice!
            old = this.chart;
            Controls.Add(this.chart);
        }

        private void OsvjeziGraf_Tick(object sender, EventArgs e)
        {
            nacrtajGraf();
        }
    }
}
