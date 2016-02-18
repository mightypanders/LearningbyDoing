using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BienenStockVerwaltung
{
    public partial class Form1 : Form
    {
        private Bienenkoenigin Koenigin;
        public Form1()
        {
            InitializeComponent();
            Koenigin = new Bienenkoenigin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koenigin.NaechsteSchichtArbeiten();
        }
    }
}
