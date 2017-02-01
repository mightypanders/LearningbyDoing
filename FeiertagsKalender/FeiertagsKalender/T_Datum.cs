using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiertagsKalender
{
    public class C_Datum

    {
        #region Member
        private int tag;
        private int monat;
        private int jahr;
        private enum Wochentag
        {
            Samstag = 0,
            Sonntag = 1,
            Montag,
            Dienstag,
            Mittwoch,
            Donnerstag,
            Freitag
        }
        #endregion
        #region Accessoren
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
        #endregion
        public C_Datum()
        {

        }
        #region Methoden
        /// <summary>
        /// Übersetzt den Tagescode aus getTagNummer() anhand T_Datum.Wochentag in einen lesbaren Namen
        /// </summary>
        /// <param name="lTag"></param>
        /// <param name="lMonat"></param>
        /// <param name="lJahr"></param>
        /// <returns></returns>
        public string getWochentag(int lTag, int lMonat, int lJahr)
        {
            int temp = getTagNummer(lTag, lMonat, lJahr);
            return Enum.GetName(typeof(Wochentag), temp);
        }
        /// <summary>
        /// Für ein gegebens Datum wird bestimmt welcher Wochentag es ist.
        /// </summary>
        /// <param name="lTag"></param>
        /// <param name="lMonat"></param>
        /// <param name="lJahr"></param>
        /// <returns>Einen Wochentagscode entsprechend T_Datum.Wochentag.</returns>
        public int getTagNummer(int lTag, int lMonat, int lJahr)
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
            int temp = (lTag + (((lMonat + 1) * 26) / 10) + (lJahr % 100) + ((lJahr % 100) / 4) + 5 - ((lJahr / 100) / 4)) % 7;
            return temp;
        }
        /// <summary>
        /// Testet ob das Jahr ein Schaltjahr ist.
        /// </summary>
        /// <param name="lJahr">Eine Jahreszahl größer 0</param>
        /// <returns>True wenn das Jahr ein Schaltjahr ist.</returns>
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
        #endregion

    }
}
