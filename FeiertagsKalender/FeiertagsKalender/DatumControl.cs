using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace FeiertagsKalender
{

    public class C_DatumControl
    {
        private C_Datum dat;
        public C_DatumControl(C_Datum _dat)
        {
            dat = _dat;
        }
        /// <summary>
        /// Gibt die Tage eines Monats als Liste wieder, nach T_Datum.Wochentage codiert
        /// </summary>
        /// <param name="lMonat">Monat als int (1-12)</param>
        /// <param name="lJahr">Jahr als int (0-????)</param>
        /// <returns>Liste an ints, Werte 0-6, Länge 28-31</returns>
        public List<int> TagesListe(int lMonat, int lJahr)
        {
            int tagesAnzahl = TagAnzahl(lMonat, lJahr);
            var monat = MonatsListe(tagesAnzahl, lMonat, lJahr);

            return monat;
        }
        private List<int> MonatsListe(int monatstage, int lMonat, int lJahr)
        {
            List<int> monat = new List<int>();
            for (int i = 1; i <= monatstage; i++)
            {
                monat.Add(dat.getTagNummer(i, lMonat, lJahr));
            }
            return monat;
        }
        /// <summary>
        /// Gibt die Anzahl der Tage in einem Monat zurück
        /// </summary>
        /// <param name="lMonat">Monat als int (1-12)</param>
        /// <param name="lJahr">Jahr als int (0-????)</param>
        private int TagAnzahl(int lMonat, int lJahr)
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
                    tage = (dat.testSchaltjahr(lJahr)) ? 29 : 28;
                    break;
                default:
                    tage = 31;
                    break;
            }
            return tage;
        }

    }
}