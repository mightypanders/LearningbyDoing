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
        public float ergebnis;
        public string _operator;
        public BorderStyle single = System.Windows.Forms.BorderStyle.FixedSingle;
        public BorderStyle none = System.Windows.Forms.BorderStyle.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRechnen_Click(object sender, EventArgs e)
        { float links, rechts;
            links = float.Parse(this.textBox1.Text);
            rechts = float.Parse(this.textBox2.Text);
            
            switch (_operator)
                {
                case "+":
                    ergebnis = links + rechts;
                    break;
                case "/":
                    ergebnis = links / rechts;
                    break;
                case "x":
                    ergebnis = links * rechts;
                    break;
                case "-":
                    ergebnis = links - rechts;
                    break;
                default:
                    break;
                    
            }
            this.textBox3.Text = ergebnis.ToString();
        }
        private void operatorchange(object sender, EventArgs e)
        {
            if (sender == this.lblplus)
            {
                _operator = "+";
                this.lblplus.BorderStyle = single;
                this.lblminus.BorderStyle = none;
                this.lblmulti.BorderStyle = none;
                this.lbldivi.BorderStyle = none;
            }
            if (sender == this.lbldivi)
            {
                _operator = "/";
                this.lbldivi.BorderStyle = single;
                this.lblplus.BorderStyle = none;
                this.lblmulti.BorderStyle = none;
                this.lblminus.BorderStyle = none;
            }
            if (sender == this.lblminus)
            {
                _operator = "-";
                this.lblminus.BorderStyle = single;
                this.lblplus.BorderStyle = none;
                this.lblmulti.BorderStyle = none;
                this.lbldivi.BorderStyle = none;
            }
            if (sender == this.lblmulti)
            {
                _operator = "x";
                this.lblmulti.BorderStyle = single;
                this.lblminus.BorderStyle = none;
                this.lbldivi.BorderStyle = none;
                this.lblplus.BorderStyle = none;
            }
        }
    }
}
