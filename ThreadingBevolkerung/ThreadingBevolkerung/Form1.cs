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
using System.Windows.Forms.DataVisualization.Charting;

namespace ThreadingBevolkerung
{
    public partial class Form1 : Form

    {
        public Thread _valueThread;
        private Population _population;
        private bool startChanged = false;
        private Series series;

        public Form1()
        {
            InitializeComponent();
            _population = new Population();
            series = new Series();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _valueThread = new Thread(() => showValues(true));
            _valueThread.Start();
            _population.Count = (startChanged) ? this.numericUpDown1.Value : _population.Count;
            _population.StartThreads();
            startChanged = false;
            series = this.chart1.Series[0];
        }


        private void showValues(bool loop = false)
        {
            do
            {
                MethodInvoker UpdateLabels = delegate
                {
                    this.lblPop.Text = _population.Count.ToString();
                    this.lblBorn.Text = _population.Born.ToString();
                    this.lblDead.Text = _population.Deceased.ToString();
                    this.lblKrieg.Text = (_population.IsWar) ? "JA" : "Nein";
                    this.series.Points.Add((double)_population.Count);
                };
                Invoke(UpdateLabels);
                Thread.Sleep(_population.UpdateInterval);
            } while (loop);
        }

        private void updateChartRange(bool loop = false)
        {
            do
            {
                MethodInvoker UpdateChart = delegate
                {
                    if ((double)this.series.Points.Last().XValue >= this.chart1.ChartAreas[0].AxisX.Maximum * 0.9D)
                    {
                        this.chart1.ChartAreas[0].AxisX.Maximum *= 2;
                    }
                    if (this.series.Points.Last().YValues[0] >= this.chart1.ChartAreas[0].AxisY.Maximum * 0.9D)
                    {
                        this.chart1.ChartAreas[0].AxisY.Maximum *= 2;
                    }
                };
            } while (true);
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
            if (_valueThread != null)
                _valueThread.Abort();
            _population.StopThreads();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            StopAllThreads();
            _population.Count = 0;
            _population.Deceased = 0;
            _population.Born = 0;
            _population.UpdateInterval = 1000;
            numericUpDown2.Value = 1000;
            showValues();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAllThreads();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _population.ManualWar = !_population.ManualWar;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            _population.UpdateInterval = (int)numericUpDown2.Value;
        }

    }
}
