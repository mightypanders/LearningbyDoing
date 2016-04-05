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
            short.TryParse(Console.ReadLine(), out Warmwassertemp);
            if (Warmwassertemp < 20 || Warmwassertemp > 68)
            {
                Console.WriteLine("Bitte geben sie einen Wert zwischen 20° und 68° ein.");
                short.TryParse(Console.ReadLine(), out Warmwassertemp);
                if (Warmwassertemp < 20 || Warmwassertemp > 68)
                    Environment.Exit(Environment.ExitCode);
            }


            Console.WriteLine("Geben sie die gewünschte Neigung der Heizkurve ein");
            Double.TryParse(Console.ReadLine(), out neigungHK);
            if (neigungHK < 0.2 || neigungHK > 3.0)
            {
                Console.WriteLine("Bitte geben sie einen Wert zwischen 0,2 und 3,0 ein.");
                Double.TryParse(Console.ReadLine(), out neigungHK);
                if (neigungHK < 0.2 || neigungHK > 3.0)
                    Environment.Exit(Environment.ExitCode);
            }
            
            Console.WriteLine("Geben sie das gewünschte Niveau der Heizkurve ein");
            short.TryParse(Console.ReadLine(), out niveauHK);
            if (niveauHK > -15 || niveauHK < -40)
            {
                Console.WriteLine("Bitte geben sie einen Wert zwischen -15 und -40 ein.");

                short.TryParse(Console.ReadLine(), out niveauHK);

                if (niveauHK < -15 || niveauHK > -40)
                    Environment.Exit(Environment.ExitCode);
            }


            
            Console.WriteLine("Soll das Schwimmbad beheizt werden?");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "j":
                case "ja":
                case "yes":
                case "y":
                    this.sbHeizen = true;
                    break;
                case "n":
                case "no":
                case "nein":
                    this.sbHeizen = false;
                    break;
                default:
                    break;
            }

            Console.WriteLine("In welcher Temperatureinheit wird gerechnet? (C/F/K)");
            this.tempEinheit = Convert.ToChar(Console.ReadLine());

        }
    }

}

