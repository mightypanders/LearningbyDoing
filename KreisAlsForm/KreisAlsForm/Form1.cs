using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KreisAlsForm
{
    public partial class Form1 : Form
    {
        Kreis kreis;
        Rechteck rechteck;
        Kugel kugel;
        Kegel kegel;
        Zylinder zylinder;
        double standardwert = 1.0;

        public Form1()
        {
            InitializeComponent();

            kreis = new Kreis(standardwert);
            rechteck = new Rechteck(standardwert, standardwert);
            kugel = new Kugel(standardwert);
            kegel = new Kegel(standardwert,standardwert);
            zylinder = new Zylinder(standardwert, standardwert);

            this.txt_Binput.Text = standardwert.ToString();
            this.txt_Radinput.Text = standardwert.ToString();
        }

        private void txt_Radinput_TextChanged(object sender, EventArgs e)
        {
            WerteBerechnen();
        }

        private void WerteBerechnen()
        {
            if (this.radioButton1.Checked)
            {
                Kreiswerte();
            }
            if (this.radioButton2.Checked)
            {
                RechteckWerte();
            }
            if (this.radioButton3.Checked)
            {
                KugelWerte();
            }
            if (this.radioButton4.Checked)
            {
                KegelWerte();
            }
            if (this.radioButton5.Checked)
            {
                ZylinderWerte();
            }
        }

        private void Kreiswerte()
        {
            double InputLinks = 0.0;
            double.TryParse(txt_Radinput.Text, out InputLinks);

            kreis.setRadius(InputLinks);

            this.txt_FlOutput.Text = kreis.getFlaeche().ToString();
            this.txt_UmfOut.Text = kreis.getUmfang().ToString();
        }

        private void RechteckWerte()
        {
            double InputLinks = 0.0;
            double.TryParse(txt_Radinput.Text, out InputLinks);
            double InputRechts = 0.0;
            double.TryParse(txt_Binput.Text, out InputRechts);

            rechteck.setSeiteA(InputLinks);
            rechteck.setSeiteB(InputRechts);

            this.txt_FlOutput.Text = rechteck.getFlache().ToString();
            this.txt_UmfOut.Text = rechteck.getUmfang().ToString();

        }

        private void KugelWerte()
        {
            double InputLinks = 0.0;
            double.TryParse(txt_Radinput.Text, out InputLinks);
            double InputRechts = 0.0;
            double.TryParse(txt_Binput.Text, out InputRechts);

            kugel.setRadius(InputLinks);
            kugel.berechneOberflaeche();
            kugel.berechneVolumen();

            this.txt_FlOutput.Text = kugel.getFlaeche().ToString();
            this.txt_UmfOut.Text = kugel.getUmfang().ToString();
            this.txt_Volumen.Text = kugel.Volumen.ToString();
            this.txt_Oberfl.Text = kugel.Oberflache.ToString();
        }
        private void KegelWerte()
        {
            double InputLinks = 0.0;
            double.TryParse(txt_Radinput.Text, out InputLinks);
            double InputRechts = 0.0;
            double.TryParse(txt_Binput.Text, out InputRechts);

            kegel.setRadius(InputLinks);
            kegel.Hoehe = InputRechts;
            kegel.berechneVolumen();
            kegel.berechneOberflache();

            this.txt_FlOutput.Text = kegel.getFlaeche().ToString();
            this.txt_UmfOut.Text = kegel.getUmfang().ToString();
            this.txt_Volumen.Text = kegel.Volumen.ToString();
            this.txt_Oberfl.Text = kegel.Oberflache.ToString();
        }
        private void ZylinderWerte()
        {
            double InputLinks = 0.0;
            double.TryParse(txt_Radinput.Text, out InputLinks);
            double InputRechts = 0.0;
            double.TryParse(txt_Binput.Text, out InputRechts);

            zylinder.setRadius(InputLinks);
            zylinder.Hoehe = InputRechts;
            zylinder.berechneOberflache();
            zylinder.berechneVolumen();

            this.txt_FlOutput.Text = zylinder.getFlaeche().ToString();
            this.txt_UmfOut.Text = zylinder.getUmfang().ToString();
            this.txt_Volumen.Text = zylinder.Volumen.ToString();
            this.txt_Oberfl.Text = zylinder.Oberflache.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = "Radius eingeben";
            this.txt_SeiteBinput.Visible = false;
            this.txt_Binput.Visible = false;
            WerteBerechnen();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = "Seite A eingeben";
            this.txt_SeiteBinput.Visible = true;
            this.txt_Binput.Visible = true;
            WerteBerechnen();
        }

        private void txt_Binput_TextChanged(object sender, EventArgs e)
        {
            WerteBerechnen();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = "Radius eingeben";
            this.txt_SeiteBinput.Visible = false;
            this.txt_Binput.Visible = false;
            WerteBerechnen();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
