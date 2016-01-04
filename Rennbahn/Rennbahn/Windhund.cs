using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rennbahn
{
    public class Windhund
    {
        public int Startposition;
        public int Rennbahnlaenge;
        public PictureBox Bild = null;
        public int Ort = 0;
        public Random Zufallszahl = new Random();

        public Windhund(int Startposition, int Rennbahnlaenge, PictureBox Bild, int Ort)
        {

        }
        public bool Laufen()
        {
            this.Ort = Zufallszahl.Next(1, 5);
            return true;
        }

        public void StartposEinnehmen()
        {
            this.Ort = this.Startposition;
        }
    }
}
