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
        public Form1()
        {
            InitializeComponent();
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
    }
}
