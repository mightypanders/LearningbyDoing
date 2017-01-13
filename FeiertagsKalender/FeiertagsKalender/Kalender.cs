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
        private void CheckJahr(object sender, EventArgs e)
        {
            lbl_Schaltjahr.Text = dat.testSchaltjahr((int)UD_Jahr.Value) ? "Ja" : "Nein";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = dat.getWochentag((int)UD_Tag.Value, (int)UD_Monat.Value, (int)UD_Jahr.Value);
            this.lbl_wochentag.Text = temp;
        }
        private void showMonat(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            var list = datControl.TagesListe((int)UD_Monat.Value, (int)UD_Jahr.Value);
            setupTable(list);
            fillTable(list,(int)this.UD_Tag.Value);
        }
        #endregion
        #region Helfer
        private void selectDay(DataGridViewCell cell)
        {
            cell.Style.BackColor = Color.RoyalBlue;
            cell.Style.ForeColor = Color.Wheat;
        }
        #endregion
    }
}

