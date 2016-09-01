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
        double standardwert = 1.0;

        public Form1()
        {
            InitializeComponent();
                kreis = new Kreis(standardwert);
                rechteck = new Rechteck(standardwert, standardwert);

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
            else

                if (this.radioButton2.Checked)
            {
                RechteckWerte();
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
    }
}
