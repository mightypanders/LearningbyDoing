using System;
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

        private void txt_InputTextChanged(object sender, EventArgs e)
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
            kreis.berechneAlles();

            zeigeWerte(kreis.getFlaeche().ToString(), kreis.getUmfang().ToString(), "", "");
        }

        private void RechteckWerte()
        {
            double InputLinks = 0.0;
            double.TryParse(txt_Radinput.Text, out InputLinks);
            double InputRechts = 0.0;
            double.TryParse(txt_Binput.Text, out InputRechts);

            rechteck.setSeiteA(InputLinks);
            rechteck.setSeiteB(InputRechts);
            rechteck.berechneAlles();

            zeigeWerte(rechteck.getFlache().ToString(), rechteck.getUmfang().ToString(), "", "");
        }

        private void KugelWerte()
        {
            double InputLinks = 0.0;
            double.TryParse(txt_Radinput.Text, out InputLinks);
            double InputRechts = 0.0;
            double.TryParse(txt_Binput.Text, out InputRechts);

            kugel.setRadius(InputLinks);
            kugel.berechneAlles();

            zeigeWerte(kugel.getFlaeche().ToString(), kugel.getUmfang().ToString(), kugel.Volumen.ToString(), kugel.Oberflache.ToString());
        }
        private void KegelWerte()
        {
            double InputLinks = 0.0;
            double.TryParse(txt_Radinput.Text, out InputLinks);
            double InputRechts = 0.0;
            double.TryParse(txt_Binput.Text, out InputRechts);

            kegel.setRadius(InputLinks);
            kegel.Hoehe = InputRechts;
            kegel.berechneAlles();

            zeigeWerte(kegel.getFlaeche().ToString(), kegel.getUmfang().ToString(), kegel.Volumen.ToString(), kegel.Oberflache.ToString());
        }
        private void ZylinderWerte()
        {
            double InputLinks = 0.0;
            double.TryParse(txt_Radinput.Text, out InputLinks);
            double InputRechts = 0.0;
            double.TryParse(txt_Binput.Text, out InputRechts);

            zylinder.setRadius(InputLinks);
            zylinder.Hoehe = InputRechts;
            zylinder.berechneAlles();

            zeigeWerte(zylinder.getFlaeche().ToString(), zylinder.getUmfang().ToString(), zylinder.Volumen.ToString(), zylinder.Oberflache.ToString());
        }

        private void zeigeWerte(string FlText, string UmfText, string VolText, string ObfText)
        {
            this.txt_FlOutput.Text = FlText;
            this.txt_UmfOut.Text = UmfText;
            this.txt_Volumen.Text = VolText;
            this.txt_Oberfl.Text = ObfText;
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
            this.txt_SeiteBinput.Text = "Seite B eingeben";
            this.txt_SeiteBinput.Visible = true;
            this.txt_Binput.Visible = true;
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
            this.label1.Text = "Radius eingeben";
            this.txt_SeiteBinput.Text = "Höhe eingeben";
            this.txt_SeiteBinput.Visible = true;
            this.txt_Binput.Visible = true;
            WerteBerechnen();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = "Radius eingeben";
            this.txt_SeiteBinput.Text = "Höhe eingeben";
            this.txt_SeiteBinput.Visible = true;
            this.txt_Binput.Visible = true;
            WerteBerechnen();
        }
    }
}
