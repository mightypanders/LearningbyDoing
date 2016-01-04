using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tippspiel
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Statistik stat = new Statistik();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                pgb_schwierigkeit.Value = 800 - timer1.Interval;

                stat.Aktualisieren(true);
            }
            else
            {
                stat.Aktualisieren(false);
            }
            lbl_richtig.Text = "Richtig: " + stat.Richtig;
            lbl_falsch.Text = "Falsch: " + stat.Falsch;
            lbl_gesamt.Text = "Gesamt: " + stat.Gesamt;
            lbl_trefferquote.Text = "Trefferquote: " + stat.Trefferquote + "%";
        }

    }

    class Statistik
    {
        public int Gesamt, Falsch, Richtig, Trefferquote = 0;

        public void Aktualisieren(bool richtigeTaste)
        {
            Gesamt++;

            if (!richtigeTaste)
            {
                Falsch++;
            }
            else
            {
                Richtig++;
            }
            Trefferquote = 100 * Richtig / Gesamt;
        }
    }
}
