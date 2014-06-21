using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaKrvi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult prijava;
            using (frmPrijavaKorisnika prijavaKorisnika = new frmPrijavaKorisnika())
                prijava = prijavaKorisnika.ShowDialog();
            if (prijava == DialogResult.OK)
            {
                Application.Run(new frmBankaKrvi());
            }
        }
    }
}
