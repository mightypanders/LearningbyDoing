using System;
using System.Collections;
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
        public ArrayList showMonat(int lMonat, int lJahr)
        {
            int monatstage = MonatsTage(lMonat, lJahr);
            var monat = MonatsListe(monatstage, lMonat, lJahr);

            return monat;
        }
        public ArrayList MonatsListe(int monatstage, int lMonat, int lJahr)
        {
            ArrayList monat = new ArrayList();
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
        public DataTable makeTable(ArrayList list)
        {
            DataTable table = new DataTable();
            table.NewRow();
            int i = 1;
            foreach (int item in list)
            {
                table.Rows[(int)(Math.Floor(item / 7.0))][item] = i;
                i++;
            }
            return table;
        }
    }
}