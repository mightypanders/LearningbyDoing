using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CateringKostenRechner
{
    class Abendessen
    {
        private int Personenanzahl = 0;
        private decimal Gesamtkosten;
        private bool trocken;
        private decimal GKproPers = 0.0M;
        private decimal dekokosten = 0.0M;

        public const int EssenskostenproPerson = 25;

        public Abendessen(int Personen)
        {
            this.Personenanzahl = Personen;
        }

        public void TrockenerAbendWaehlen(bool gew)
        {
            this.trocken = gew;
        }

        public void DekokostenBerechnen(bool ausgef)
        {
            if (ausgef)
                dekokosten = Personenanzahl * 15 + 50;
            else
                dekokosten = Personenanzahl * 7.5M + 30;
        }

        public decimal KostenBerechnen(bool trocken)
        {
            //if(trocken)
            //    Gesamtkosten = 
            //    else

            Gesamtkosten = dekokosten;
            return 0.0M;
            ;
        }
    }

}
