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
        public int nummer;
        public int Startposition;
        public int Rennbahnlaenge;
        public PictureBox Bild = null;
        public int Ort = 0;
        public Random Zufallszahl = new Random();
        public Label Position = null;

        public Windhund(int nummer, int Startposition, int Rennbahnlaenge, PictureBox Bild, int Ort, Label Pos)
        {
            this.nummer = nummer;
            this.Startposition = Startposition;
            this.Rennbahnlaenge = Rennbahnlaenge;
            this.Bild = Bild;
            this.Ort = Ort;
            this.Position = Pos;

        }
        public bool Laufen()
        {
            if (this.Ort < this.Rennbahnlaenge)
            {
                this.Ort += Zufallszahl.Next(1, 5);
                this.Zufallszahl = new Random();
                return true;
            }
            else { return false; }

        }


        public void StartposEinnehmen()
        {
            this.Ort = this.Startposition;
            this.Position.Text = this.Ort.ToString();
        }
    }
}
