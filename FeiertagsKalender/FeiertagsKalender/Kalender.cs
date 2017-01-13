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
            foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            {
                item.ReadOnly = true;
            }
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
            putIntoTable(list);
        }
        private void CheckJahr(object sender, EventArgs e)
        {
            if (dat.testSchaltjahr((int)UD_Jahr.Value))
            {
                lbl_Schaltjahr.Text = "Ja";
            }
            else
            {
                lbl_Schaltjahr.Text = "Nein";
            }
        }
        public DataTable makeTable(List<int> list)
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
        public void putIntoTable(List<int> list)
        {
            this.dataGridView1.Rows.Add();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0 || list[i] == 1)
                {
                    this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[list[i]].Value = i;
                }
                if (list[i] == 2 && i != 0 && i != list.Count - 1)
                {
                    this.dataGridView1.Rows.Add();
                }
            }
        }
    }
}

