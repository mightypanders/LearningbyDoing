using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasisUndUnterklassen
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class eineKlasse
    {
        public eineKlasse(string Basisparam)
        {
            MessageBox.Show("Hier ist die Basisklasse " + Basisparam);
        }
    }
    class eineUnterklasse : eineKlasse
    {
        public eineUnterklasse(string Basisparameter, int andererWert) : base(Basisparameter)
        {

            MessageBox.Show("Hier ist die Unterklasse " + Basisparameter + " und " + andererWert);
        }
    }

}
