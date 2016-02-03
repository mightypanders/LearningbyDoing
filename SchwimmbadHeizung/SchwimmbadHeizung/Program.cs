using System;

namespace SchwimmbadHeizung
{
    class Program
    {
        static void Main(string[] args)
        {

            Heizungskonfiguration K = new Heizungskonfiguration();
            K.liesKonf();
            K.druckeKonfig();
            Console.ReadKey();
        }
    }
    class Heizungskonfiguration
    {
        private string techniker;
        private short Warmwassertemp;
        private double neigungHK;
        private short niveauHK;
        private bool sbHeizen;
        private char tempEinheit;
        private int betriebstdWartung;

        public Heizungskonfiguration() { }


        public Heizungskonfiguration(string techniker, short Warmwassertemp, double neigungHK, short niveauHK, bool sbHeizen, char tempEinheit, int betriebstdWartung)
        {
            this.techniker = techniker;
            this.Warmwassertemp = Warmwassertemp;
            this.neigungHK = neigungHK;
            this.niveauHK = niveauHK;
            this.sbHeizen = sbHeizen;
            this.tempEinheit = tempEinheit;
            this.betriebstdWartung = betriebstdWartung;

        }

        public void druckeKonfig()
        {
            Console.WriteLine(techniker);
            Console.WriteLine(Warmwassertemp.ToString());
            Console.WriteLine(neigungHK.ToString());
            Console.WriteLine(niveauHK.ToString());
            Console.WriteLine(sbHeizen.ToString());
            Console.WriteLine(tempEinheit);
            Console.WriteLine(betriebstdWartung.ToString());
        }
        public void liesKonf()
        {
            Console.WriteLine("Geben sie den Namen des Technikers ein");
            this.techniker = Console.ReadLine();

            Console.WriteLine("Geben sie die Soll Temperatur des Wassers ein");
            this.Warmwassertemp = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Geben sie die gewünschte Neigung der Heizkurve ein");
            this.neigungHK = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie das gewünschte Niveau der Heizkurve ein");
            this.niveauHK = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Soll das Schwimmbad beheizt werden?");
            string input = Console.ReadLine();

            if (input == "J" || input == "j" || input == "y" || input == "Y")
            {
                this.sbHeizen = true;
            }
            else
            {
                this.sbHeizen = false;
            }

            Console.WriteLine("In welcher Temperatureinheit wird gerechnet? (C/F/K)");
            this.tempEinheit = Convert.ToChar(Console.ReadLine());

        }
    }

}

