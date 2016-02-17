using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CateringKostenRechner
{
    class Party
    {
        private int Personenzahl;
        private decimal GK;
        private decimal dekokosten;
        private decimal dekopauschale;
        private decimal gKproPers;
        private decimal rabatt = 1M;
        private bool exklusiveDeko;
        private decimal Sonderkosten = 100M;

        public const int EssenskostenproPerson = 25;
        public Party(int Pers)
        {
            this.Personenzahl = Pers;
        }

        public int Personen
        {
            get
            {
                return Personenzahl;
            }

            set
            {
                Personenzahl = value;
                if (value >= 12)
                    Sonderkosten = 100M;
                else
                    Sonderkosten = 0M;
                DekokostenBerechnen(ExklusiveDeko);
            }
        }
        public decimal Gesamtkosten
        {
            get
            {
                return GK;
            }

            set
            {
                GK = value;
            }
        }
        public decimal Dekokosten
        {
            get
            {
                return dekokosten;
            }

            set
            {
                dekokosten = value;
            }
        }
        public decimal Dekopauschale
        {
            get
            {
                return dekopauschale;
            }

            set
            {
                dekopauschale = value;
            }
        }
        public decimal GKproPers
        {
            get
            {
                return gKproPers;
            }

            set
            {
                gKproPers = value;
            }
        }
        public decimal Rabatt
        {
            get
            {
                return rabatt;
            }

            set
            {
                rabatt = value;
            }
        }
        public bool ExklusiveDeko
        {
            get
            {
                return exklusiveDeko;
            }

            set
            {
                exklusiveDeko = value;
                DekokostenBerechnen(ExklusiveDeko);
            }
        }

        public void DekokostenBerechnen(bool ausgef)
        {
            //ExklusiveDeko = ausgef;
            if (ausgef)
            {
                Dekokosten = (15M * Personen) + 50M;

            }
            else
            {
                Dekokosten = (7.5M * Personen) + 30M;

            }
        }

        public virtual decimal KostenBerechnen()
        {
            Gesamtkosten = (Dekokosten + ((GKproPers + EssenskostenproPerson) * Personen)) * Rabatt;
            if (Personen > 12)
            {
                Gesamtkosten += Sonderkosten;
            }

            return Gesamtkosten;
            ;
        }
    }
}
