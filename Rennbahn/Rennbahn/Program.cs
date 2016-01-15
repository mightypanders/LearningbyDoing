using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rennbahn
{
    static class Program
    {
        public static Spieler[] spArr;
        public static Windhund[] whArr;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            spielerAnlegen();
            winhundeAnlegen();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void spielerAnlegen()
        {

            spArr = new Spieler[3];
            spArr[0] = new Spieler("Tim", 1, null, 45);
            spArr[1] = new Spieler("Tom", 2, null, 50);
            spArr[2] = new Spieler("John", 3, null, 60);

        }
        static void winhundeAnlegen()
        {
            whArr = new Windhund[4];
            whArr[0] = new Windhund(1, 0, 0, null, 0);
            whArr[1] = new Windhund(2, 0, 0, null, 0);
            whArr[2] = new Windhund(3, 0, 0, null, 0);
            whArr[3] = new Windhund(4, 0, 0, null, 0);

        }
    }
}
