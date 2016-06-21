using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinsesZins
{
    class Program
    {
        static void Main(string[] args)
        {

            double zinsfuss = 0;
            double startKapital = 0;
            double endkapital = 0;
            int laufzeit = 0;


            Console.WriteLine("bitte geben sie ihr startkapital ein: ");
            Double.TryParse(Console.ReadLine(), out startKapital);
            Console.WriteLine("bitte geben sie den Zinsfuß ein: ");
            Double.TryParse(Console.ReadLine(), out zinsfuss);
            Console.WriteLine("bitte geben sie die Laufzeit ein: ");
            Int32.TryParse(Console.ReadLine(), out laufzeit);
            endkapital = ZinsesZins(startKapital, laufzeit, zinsfuss);
            Console.WriteLine("endkapital nach "+laufzeit+" Jahren ist " + endkapital+"€");
            Console.ReadKey();

        }

        static double ZinsesZins(double kapital, int laufzeit, double Zins)
        {
            if (laufzeit > 1)
            {
                kapital = ZinsesZins(kapital, laufzeit - 1, Zins);
            }
            kapital = kapital * (1 + (Zins / 100));
            return kapital;
        }
    }
}
