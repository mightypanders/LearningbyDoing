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
        Geburtstagsfeier geb;
        public PartyPlaner()
        {
            InitializeComponent();
            abendessen = new Abendessen((int)numericUpDown1.Value, chk_trocken_abendessen.Checked, chk_ausgefallen_abendessen.Checked);
            geb = new Geburtstagsfeier((int)numericUpDown2.Value, chk_exklusiv_geburtstag.Checked, txt_kuchen_geburstag.Text);
            abendessen.TrockenerAbendWaehlen(chk_trocken_abendessen.Checked);
            abendessen.DekokostenBerechnen(chk_ausgefallen_abendessen.Checked);
            AbendessenKostenAnzeigen();
            geb.DekokostenBerechnen(chk_exklusiv_geburtstag.Checked);
            GeburtstagsfeierKostenBerechen();

        }

        private void AbendessenKostenAnzeigen()
        {
            abendessen.DekokostenBerechnen(chk_ausgefallen_abendessen.Checked);
            decimal kosten = abendessen.KostenBerechnen();
            lbl_kosten_abendessen.Text = kosten.ToString("c");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            abendessen.Personen = (int)(numericUpDown1.Value);
            AbendessenKostenAnzeigen();
        }

        private void chk_ausgefallen_CheckStateChanged(object sender, EventArgs e)
        {
            abendessen.DekokostenBerechnen(chk_ausgefallen_abendessen.Checked);
            AbendessenKostenAnzeigen();
        }

        private void chk_trocken_CheckedChanged(object sender, EventArgs e)
        {
            abendessen.TrockenerAbendWaehlen(chk_trocken_abendessen.Checked);
            AbendessenKostenAnzeigen();
        }

        private void chk_exklusiv_geburtstag_CheckedChanged(object sender, EventArgs e)
        {
            geb.ExklusiveDeko = chk_exklusiv_geburtstag.Checked;
            GeburtstagsfeierKostenBerechen();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            geb.Personen = (int)numericUpDown2.Value;
            GeburtstagsfeierKostenBerechen();
        }

        private void txt_kuchen_geburstag_TextChanged(object sender, EventArgs e)
        {
            geb.Kuchentext = txt_kuchen_geburstag.Text;
            GeburtstagsfeierKostenBerechen();
        }

        private void GeburtstagsfeierKostenBerechen()
        {
            txt_kuchen_geburstag.Text = geb.Kuchentext;
            decimal kosten = geb.KostenBerechnen();
            lbl_kosten_geburtstag.Text = kosten.ToString("c");
        }
    }
}
