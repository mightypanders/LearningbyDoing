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
        public int Distanz = 0;

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
                this.Distanz = Zufallszahl.Next(1, 10);
                this.Ort += this.Distanz;
                this.Zufallszahl = new Random();
                this.Bild.Left += this.Distanz;
                return true;
            }
            else
            {
                return false;
            }

        }


        public void StartposEinnehmen()
        {
            this.Ort = this.Startposition;
            this.Bild.Left = 13;
            this.Position.Text = this.Ort.ToString();
        }
    }
}
