using System;
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
        public PictureBox[] whPBarray;
        public Form1()

        {
            InitializeComponent();
            Rennbahnlaenge = this.pb_hintergrund.Width - 150;
            spielerAnlegen();
#if DEBUG
            showDebugLabels();
#endif
            windhundeAnlegen();
        }

        private void showDebugLabels()
        {
            this.lblH1Pos.Visible = this.lblH2Pos.Visible = this.lblH3Pos.Visible = this.lblH4Pos.Visible = true;
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
            whPBarray = new PictureBox[4];
            whArr[0] = new Windhund(1, 0, Rennbahnlaenge, this.pictureBox1, 0, lblH1Pos);
            whArr[1] = new Windhund(2, 0, Rennbahnlaenge, this.pictureBox2, 0, lblH2Pos);
            whArr[2] = new Windhund(3, 0, Rennbahnlaenge, this.pictureBox3, 0, lblH3Pos);
            whArr[3] = new Windhund(4, 0, Rennbahnlaenge, this.pictureBox4, 0, lblH4Pos);
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

                        int BildOrt = whArr[i].Ort; // potentiell unnötig?


#if DEBUG //beta Anzeige, solange keine Bilder da sind.s
                        whArr[i].Position.Text = whArr[i].Ort.ToString();
#endif


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
            RennenBeendet();

        }
        private void RennenBeendet()
        {
            foreach (Spieler S in spArr)
            {
                if (Gewinner != null)
                    S.Einkassieren(Gewinner.nummer);

                Gewinner = null;
            }

            foreach (Windhund W in whArr)
            {
                W.StartposEinnehmen();

            }

            this.Refresh();
        }
    }
}
