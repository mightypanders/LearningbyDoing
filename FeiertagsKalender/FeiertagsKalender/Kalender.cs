using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeiertagsKalender
{
    public partial class Kalender : Form
    {
        T_Datum dat;
        Control datControl;

        public Kalender()
        {
            InitializeComponent();
            dat = new T_Datum();
            datControl = new Control(dat);
        }
        #region HauptLogik
        /// <summary>
        /// Die bereits vorbereitete Tabelle wird mit Wochentags Daten gefüllt.
        /// </summary>
        /// <param name="list">Die Tage des darzustellenden Monats.</param>
        /// <param name="highlightTag">Der Tag der in der Form ausgewählt wurde.</param>
        private void fillTable(List<int> list,int highlightTag)
        {
            int startfield = 0;
            int dayvalue = 1;
            int endvalue = list.Count;
            //der erste Tag in der Tagesliste den Code für Samstag oder Sonntag hat
            //müssen diese "rübergeschoben" werden um die richtige zuordnung des zellen indexes
            //zu gewährleistens
            startfield = (list[0] == 1 || list[0] == 0) ? list[0] + 5 : list[0] - 2;

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                startfield = (i != 0) ? 0 : startfield;
                for (int j = startfield; j < this.dataGridView1.Rows[i].Cells.Count; j++)
                {
                    this.dataGridView1.Rows[i].Cells[j].Value = dayvalue;
                    if (dayvalue == highlightTag)
                        selectDay(this.dataGridView1.Rows[i].Cells[j]);
                    if (dayvalue < endvalue)
                        dayvalue++;
                    else
                        break;
                }
            }
        }
        /// <summary>
        /// Entsprechend einer richtig formatierten TagesListe werden Wochenzeilen in das GridView geschrieben
        /// </summary>
        /// <param name="list">Eine Liste von Tagen, codiert in T_Datum.Wochentag Codes</param>
        public void setupTable(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                //erzeut eine neue Zeile im GridView wenn ein Montag entdeckt wird
                // Montag hat den Tagescode == 2
                if (list[i] == 2 && i != 0 && i != list.Count)
                {
                    this.dataGridView1.Rows.Add();
                }
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Wenn das Jahr ein Schaltjahr ist, wird das Label von "Nein" auf "Ja" gesetzt um umgekehrt
        /// </summary>
        private void CheckJahr()
        {
            lbl_Schaltjahr.Text = dat.testSchaltjahr((int)UD_Jahr.Value) ? "Ja" : "Nein";
            WochentagEinsetzen();
        }
        /// <summary>
        /// Die Form zeigt den Wochentag des ausgewählten Datums als separates Label über dem Kalender an
        /// </summary>
        private void WochentagEinsetzen()
        {
            string temp = dat.getWochentag((int)UD_Tag.Value, (int)UD_Monat.Value, (int)UD_Jahr.Value);
            this.lbl_wochentag.Text = temp;
        }
        /// <summary>
        /// Der Wochentag wird als Label gesetzt, das Schaltjahr wird bestimmt und das Grid geleert und richtig erneut befüllt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showMonat(object sender, EventArgs e)
        {
            WochentagEinsetzen();
            CheckJahr();
            this.dataGridView1.Rows.Clear();
            var list = datControl.TagesListe((int)UD_Monat.Value, (int)UD_Jahr.Value);
            setupTable(list);
            fillTable(list,(int)this.UD_Tag.Value);
        }
        #endregion
        #region Helfer
        /// <summary>
        /// Hinterlegt die Zelle die dem ausgewählten Tag entspricht farbig.
        /// </summary>
        /// <param name="cell"></param>
        private void selectDay(DataGridViewCell cell)
        {
            cell.Style.BackColor = Color.RoyalBlue;
            cell.Style.ForeColor = Color.Wheat;
        }
        #endregion
    }
}

