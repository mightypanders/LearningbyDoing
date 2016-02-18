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
        private Arbeitsbiene[] arbeiter;

        //public enum
        public Form1()
        {
            InitializeComponent();
            arbeiter[0] = new Arbeitsbiene(new string[] { "Nektar sammeln" });
            Koenigin = new Bienenkoenigin(arbeiter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koenigin.NaechsteSchichtArbeiten();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koenigin.ArbeitZuweisen(cbb_auftrage.Text, (int)nud_shifts.Value);
        }
    }
}
