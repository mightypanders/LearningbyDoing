using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tread_Beispiel
{

    public partial class Form1 : Form
    {

        testing inc = new testing();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Thread t1 = new Thread(new ThreadStart(inc.Incrementer));
            Thread t2 = new Thread(new ThreadStart(inc.Decrementer));

            t1.Start();
            t2.Start();

            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // listBox1.Items.Add(inc.Incr);
            textBox1.Text = Convert.ToString(inc.Incr) + " " + Convert.ToString(inc.Decr);
        }
    }

    public class testing
    {

        public int Incr { set; get; }
        public int Decr { set; get; }

        public void Incrementer()
        {
            for (int i = 0; i < 20; i++)
            {
                Incr = i;
                System.Threading.Thread.Sleep(200);
            }
        }

        public void Decrementer()
        {
            for (int i = 100; i > 0; i--)
            {
                Decr = i;
                System.Threading.Thread.Sleep(400);
            }
        }

    }

}
