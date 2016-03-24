using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KilometerRechner
{
    public partial class Form1 : Form
    {
        public int tachoEnde, tachoAnfang = 0;
        public double gefahren, erstattungsbetrag = 0.0;
        public double erstattungssatz = 0.39;

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            tachoEnde = (int)this.numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tachoAnfang = (int)this.numericUpDown1.Value;
        }

        

        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tachoAnfang < tachoEnde)
            {
                gefahren = tachoEnde - tachoAnfang;
                erstattungsbetrag = gefahren * erstattungssatz;
                label4.Text = erstattungsbetrag + "€";
                label6.Text = gefahren.ToString()+"km";
            }
            else
            {
                MessageBox.Show("Anfangsstand muss kleiner sein als Endstand", "Keine Berechnung möglich");
            }
        }
    }
}
