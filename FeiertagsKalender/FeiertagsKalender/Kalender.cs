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
            //foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            //{
            //    item.ReadOnly = true;
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = dat.getWochentag((int)UD_Tag.Value, (int)UD_Monat.Value, (int)UD_Jahr.Value);
            this.lbl_wochentag.Text = temp;
        }
        private void showMonat(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            var list = datControl.showMonat((int)UD_Monat.Value, (int)UD_Jahr.Value);
            setupTable(list);
            //fillTable(list);
        }

        private void fillTable(List<int> list)
        {
            throw new NotImplementedException();
        }

        private void CheckJahr(object sender, EventArgs e)
        {
            lbl_Schaltjahr.Text = dat.testSchaltjahr((int)UD_Jahr.Value) ? "Ja" : "Nein";
        }
        public void setupTable(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                //erzeut eine neue Zeile im GridView wenn ein Montag entdeckt wird
                // Montag hat den Tagescode == 2
                if (list[i] == 2 && i != 0 && i != list.Count )
                {
                    this.dataGridView1.Rows.Add();
                }
            }
        }
    }
}

