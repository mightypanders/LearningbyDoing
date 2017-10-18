using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Windows;

namespace ThreadingBevolkerung
{
    public partial class Form1 : Form

    {
        public Thread values;
        private Population pop;
        private bool startChanged = false;
        public Form1()
        {
            InitializeComponent();
            pop = new Population();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            values = new Thread(() => showValues(true));
            values.Start();
            pop.Count = (startChanged) ? this.numericUpDown1.Value : pop.Count;
            pop.StartThreads();
            startChanged = false;
        }


        private void showValues(bool loop = false)
        {
            do
            {
                MethodInvoker UpdateLabels = delegate
                {
                    this.lblPop.Text = pop.Count.ToString();
                    this.lblBorn.Text = pop.Born.ToString();
                    this.lblDead.Text = pop.Deceased.ToString();
                    this.lblKrieg.Text = (pop.IsWar) ? "JA" : "Nein";
                };
                Invoke(UpdateLabels);
                Thread.Sleep(pop.UpdateInterval);
            } while (loop);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            startChanged = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopAllThreads();
        }

        private void StopAllThreads()
        {

            if (values != null)
                values.Abort();
            pop.StopThreads();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            StopAllThreads();
            pop.Count = 0;
            pop.Deceased = 0;
            pop.Born = 0;
            pop.UpdateInterval = 1000;
            numericUpDown2.Value = 1000;
            showValues();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAllThreads();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pop.ManualWar = !pop.ManualWar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            pop.UpdateInterval = (int)numericUpDown2.Value;
        }

    }
}
