using System;
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

        public Kalender()
        {
            InitializeComponent();
            dat = new T_Datum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = dat.getWochentag((int)UD_Tag.Value, (int)UD_Monat.Value, (int)UD_Jahr.Value);
            this.lbl_wochentag.Text = temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CheckJahr_Click(object sender, EventArgs e)
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
    }
}
