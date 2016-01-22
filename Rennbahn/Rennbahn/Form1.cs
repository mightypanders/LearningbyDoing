using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rennbahn
{
    public partial class Form1 : Form
    {
        public Spieler[] spArr;
        public Windhund[] whArr;
        public Spieler Wetter;
        public Windhund Gewinner = null;
        public int Rennbahnlaenge;
        public Form1()

        {
            InitializeComponent();
            Rennbahnlaenge = this.pb_hintergrund.Width / 2;
            spielerAnlegen();
            windhundeAnlegen();
        }
        private void btn_wettet_Click(object sender, EventArgs e)
        {
            Wetter.WetteAbgeben((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Wetter.LabelAktualisieren();
            this.Refresh();
        }

        #region Anlegen
        public void spielerAnlegen()
        {

            spArr = new Spieler[3];
            spArr[0] = new Spieler("Tim", 1, 45, this.lbl_wette1, this.rb_1);
            spArr[1] = new Spieler("Tom", 2, 50, this.lbl_wette2, this.rb_2);
            spArr[2] = new Spieler("John", 3, 60, this.lbl_wette3, this.rb_3);

        }
        public void windhundeAnlegen()
        {
            whArr = new Windhund[4];
            whArr[0] = new Windhund(1, 0, Rennbahnlaenge, null, 0, lblH1Pos);
            whArr[1] = new Windhund(2, 0, Rennbahnlaenge, null, 0, lblH2Pos);
            whArr[2] = new Windhund(3, 0, Rennbahnlaenge, null, 0, lblH3Pos);
            whArr[3] = new Windhund(4, 0, Rennbahnlaenge, null, 0, lblH4Pos);

        }
        #endregion


        private void RBCheck(object sender, EventArgs e)
        {
            Wetter = spArr[int.Parse(((RadioButton)sender).Tag.ToString())];
            label2.Text = spArr[int.Parse(((RadioButton)sender).Tag.ToString())].name;
        }

        private void btn_Rennen_Click(object sender, EventArgs e)
        {
            while (Gewinner == null)
            {
                for (int i = 0; i < whArr.Length; i++)
                {
                    if (whArr[i].Laufen())
                    {
                        //move graphics
                        int BildOrt = whArr[i].Ort;
                        whArr[i].Position.Text = whArr[i].Ort.ToString();
                        this.Refresh();
                        BildOrt = 0;
                    }
                    else
                    {
                        Gewinner = whArr[i];
                        break;
                    }

                }
            }
            MessageBox.Show(String.Format("Der Gewinner ist Hund Nummer {0}. Herzlichen Glückwunsch!", Gewinner.nummer.ToString()));

        }
    }
}
