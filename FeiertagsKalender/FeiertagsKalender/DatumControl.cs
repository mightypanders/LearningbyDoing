using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace FeiertagsKalender
{

    public class Control
    {
        T_Datum dat;
        public Control(T_Datum _dat)
        {
            dat = _dat;
        }
        public List<int> showMonat(int lMonat, int lJahr)
        {
            int monatstage = MonatsTage(lMonat, lJahr);
            var monat = MonatsListe(monatstage, lMonat, lJahr);

            return monat;
        }
        public List<int> MonatsListe(int monatstage, int lMonat, int lJahr)
        {
            List<int> monat = new List<int>();
            for (int i = 1; i <= monatstage; i++)
            {
                monat.Add(dat.getTagNummer(i, lMonat, lJahr));
            }
            return monat;
        }
        public int MonatsTage(int lMonat, int lJahr)
        {
            int tage = 0;
            switch (lMonat)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    tage = 30;
                    break;
                case 2:
                    if (dat.testSchaltjahr(lJahr))
                        tage = 29;
                    else tage = 28;
                    break;
                default:
                    tage = 31;
                    break;
            }
            return tage;
        }

    }
}