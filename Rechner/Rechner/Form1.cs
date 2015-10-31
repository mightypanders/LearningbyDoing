using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechner
{
    public partial class Form1 : Form
    {
        public string _operator;
        public BorderStyle single = System.Windows.Forms.BorderStyle.FixedSingle;
        public BorderStyle none = System.Windows.Forms.BorderStyle.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRechnen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {   if (label1.BorderStyle == none)
            {
                label1.BorderStyle = single;
            }
            else
            {
                label1.BorderStyle = none;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.BorderStyle == none)
            {
                label3.BorderStyle = single;
            }
            else
            {
                label3.BorderStyle = none;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.BorderStyle == none)
            {
                label2.BorderStyle = single;
            }
            else
            {
                label2.BorderStyle = none;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.BorderStyle == none)
            {
                label4.BorderStyle = single;
            }
            else
            {
                label4.BorderStyle = none;
            }
        }
       
    }
}
