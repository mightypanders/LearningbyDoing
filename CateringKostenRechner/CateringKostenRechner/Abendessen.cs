using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CateringKostenRechner
{
    class Abendessen
    {
        private int Personenanzahl;
        private decimal Gesamtkosten;
        private decimal GKproPers;
        private decimal rabatt;
        private decimal dekokosten;
        private decimal dekopauschale;
        public const int EssenskostenproPerson = 25;

        public Abendessen(int Personen)
        {
            this.Personenanzahl = Personen;
        }
        public int Personen
        {
            get
            {
                return Personenanzahl;
            }
            set
            {
                Personenanzahl = value;
            }
        }

        public void TrockenerAbendWaehlen(bool gew)
        {
            if (gew)
            {
                GKproPers = 5M;
                rabatt = 0.95M;
            }
            else
            {
                GKproPers = 20M;
                rabatt = 1M;
            }
        }

        public void DekokostenBerechnen(bool ausgef)
        {
            if (ausgef)
            {
                dekokosten = 15M;
                dekopauschale = 50M;
            }
            else
            {
                dekokosten = 7.5M;
                dekopauschale = 30M;
            }
        }

        public decimal KostenBerechnen(bool trocken)
        {


            Gesamtkosten = (((dekokosten + GKproPers + EssenskostenproPerson) * Personenanzahl) + dekopauschale) * rabatt;
            return Gesamtkosten;
            ;
        }
    }

}
