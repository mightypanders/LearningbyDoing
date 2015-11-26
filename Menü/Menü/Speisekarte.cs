using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menü
{
    public partial class Speisekarte : Form
    {
        public Speisekarte()
        {
            
            InitializeComponent();
            holeMenü();
        }
        public void holeMenü()
        {
            MenüMacher menü = new MenüMacher() { Zufallszahl = new Random() };
            
            this.label1.Text = menü.MenüEintragHolen();
            this.label2.Text = menü.MenüEintragHolen();
            this.label3.Text = menü.MenüEintragHolen();
            this.label4.Text = menü.MenüEintragHolen();
            this.label5.Text = menü.MenüEintragHolen();
            this.label6.Text = menü.MenüEintragHolen();

            }

        private void button1_Click(object sender, EventArgs e)
        {
            holeMenü();
            this.Refresh();
        }
    }
}
