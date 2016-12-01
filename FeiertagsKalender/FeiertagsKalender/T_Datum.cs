using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiertagsKalender
{
    class T_Datum

    {
        private int tag;
        private int monat;
        private int jahr;
        private enum Wochentag
        {
            Samstag =0,
            Sonntag = 1,
            Montag,
            Dienstag,
            Mittwoch,
            Donnerstag,
            Freitag            
        }
        public int Tag
        {
            get
            {
                return tag;
            }

            set
            {
                tag = value;
            }
        }
        public int Monat
        {
            get
            {
                return monat;
            }

            set
            {
                monat = value;
            }
        }
        public int Jahr
        {
            get
            {
                return jahr;
            }

            set
            {
                jahr = value;
            }
        }
        public T_Datum()
        {

        }
        public void showMonat(int Monat)
        {

        }
        public string getWochentag(int lTag, int lMonat, int lJahr)
        {
            switch (lMonat)
            {
                case 1:
                    lMonat = 13; lJahr--; break;
                case 2:
                    lMonat = 14; lJahr--; break;
                default:
                    break;
            }
            int temp = (lTag + (((lMonat+1) * 26) / 10) + (lJahr % 100) + ((lJahr % 100) / 4) + 5 - ((lJahr / 100) / 4)) % 7;
            return Enum.GetName(typeof(Wochentag), temp);
        }
        public bool testSchaltjahr(int lJahr)
        {
            if (lJahr % 400 == 0)
            {
                return true;
            }
            else if (lJahr % 100 == 0)
            {
                return false;
            }
            else if (lJahr % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
