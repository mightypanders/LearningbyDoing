using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rennbahn
{
    public class Wette
    {
        public int Betrag;
        public int Hund;
        public Spieler Wetter;

        public Wette(int Betrag, int Hund, Spieler Wetter)
        {
            this.Betrag = Betrag;
            this.Hund = Hund;
            this.Wetter = Wetter;
        }
        public string BeschreibungAbrufen()
        {
            return "";
        }
        public int Auszahlen(int sieger)
        {
            return 0;
        }
    }
}
