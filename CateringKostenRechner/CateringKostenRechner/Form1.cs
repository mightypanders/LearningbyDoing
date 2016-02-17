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
            abendessen = new Abendessen((int)numericUpDown1.Value);
            abendessen.TrockenerAbendWaehlen(chk_trocken.Checked);
            abendessen.DekokostenBerechnen(chk_ausgefallen.Checked);
            AbendessenKostenAnzeigen();
        }

        private void AbendessenKostenAnzeigen()
        {
            decimal kosten = abendessen.KostenBerechnen(chk_trocken.Checked);
            lbl_KostenFeld.Text = kosten.ToString("c");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            abendessen.Personen = (int)(numericUpDown1.Value);
            AbendessenKostenAnzeigen();
        }

        private void chk_ausgefallen_CheckStateChanged(object sender, EventArgs e)
        {
            abendessen.DekokostenBerechnen(chk_ausgefallen.Checked);
            AbendessenKostenAnzeigen();
        }

        private void chk_trocken_CheckedChanged(object sender, EventArgs e)
        {
            abendessen.TrockenerAbendWaehlen(chk_trocken.Checked);
            AbendessenKostenAnzeigen();
        }
    }
}
