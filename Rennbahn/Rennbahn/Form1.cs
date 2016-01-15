using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rennbahn
{
    public partial class Form1 : Form
    {
        public Spieler[] spArr;
        public Windhund[] whArr;
        public Form1()
        {
            InitializeComponent();
            spielerAnlegen();
            windhundeAnlegen();
        }


        public static void spLabelaktualisieren(Spieler p)
        {
            switch (p.nummer)
            {
                //case 1:
                //    rb_1.Text = p.name + " hat " + p.Geld + "€";
                //    lbl_wette1.Text = p.name + " wettet " + p.MeineWette.Betrag + " € auf Hund " + p.MeineWette.Hund;
                //    break;
                //case 2:
                //    rb_2.Text = p.name + " hat " + p.Geld + "€";
                //    lbl_wette2.Text = p.name + " wettet " + p.MeineWette.Betrag + " € auf Hund " + p.MeineWette.Hund;
                //    break;
                //case 3:
                //    rb_3.Text = p.name + " hat " + p.Geld + "€";
                //    lbl_wette3.Text = p.name + " wettet " + p.MeineWette.Betrag + " € auf Hund " + p.MeineWette.Hund;
                //    break;
                //default:
                //    break;
            }
        }

        private void btn_wettet_Click(object sender, EventArgs e)
        {

        }

        #region Anlegen
        public void spielerAnlegen()
        {

            spArr = new Spieler[3];
            spArr[0] = new Spieler("Tim", 1, 45);
            spArr[1] = new Spieler("Tom", 2, 50);
            spArr[2] = new Spieler("John", 3, 60);

        }
        public void windhundeAnlegen()
        {
            whArr = new Windhund[4];
            whArr[0] = new Windhund(1, 0, 0, null, 0);
            whArr[1] = new Windhund(2, 0, 0, null, 0);
            whArr[2] = new Windhund(3, 0, 0, null, 0);
            whArr[3] = new Windhund(4, 0, 0, null, 0);

        }
        #endregion

    }
}
