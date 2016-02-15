using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CateringKostenRechner
{
    public partial class PartyPlaner : Form
    {
        Abendessen abendessen;
        public PartyPlaner()
        {
            InitializeComponent();
            abendessen = new Abendessen(5);
            abendessen.TrockenerAbendWaehlen(false);
            //abendessen.DekokostenBerechnen(true);
            AbendessenKostenAnzeigen();
        }

        private void AbendessenKostenAnzeigen()
        {
            abendessen.DekokostenBerechnen(chk_ausgefallen.Checked);
            decimal kosten = abendessen.KostenBerechnen(chk_trocken.Checked);
            lbl_KostenFeld.Text = kosten.ToString("c");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AbendessenKostenAnzeigen();
        }

        private void chk_ausgefallen_CheckStateChanged(object sender, EventArgs e)
        {
            AbendessenKostenAnzeigen();
        }

        private void chk_trocken_CheckedChanged(object sender, EventArgs e)
        {
            AbendessenKostenAnzeigen();
        }
    }
}
