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
            if (Hund == sieger)
            {
                return Betrag * 2;
            }
            else
            {
                return Betrag * -1;
            }
        }
    }
}
