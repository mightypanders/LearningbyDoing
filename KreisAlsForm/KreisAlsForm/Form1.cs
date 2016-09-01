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
        Kreis kreis = new Kreis(1);

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Radinput_TextChanged(object sender, EventArgs e)
        {
            double fl = 0.0;
            double.TryParse(txt_Radinput.Text, out fl);
            kreis.setRadius(fl);            
            this.txt_FlOutput.Text = kreis.getFlaeche().ToString();
            this.txt_UmfOut.Text = kreis.getUmfang().ToString();
        }
    }
}
