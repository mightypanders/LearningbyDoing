using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rennbahn
{
    public class Spieler
    {
        public string name;
        public int nummer;
        public Wette MeineWette;
        public int Geld;
        public Label MeinLabel;
        public RadioButton MeinRadioButton;

        public Spieler(string name, int nummer, int Geld, Label lbl, RadioButton RB)
        {
            this.name = name;
            this.MeineWette = new Wette(0, 0, this);
            this.Geld = Geld;
            this.MeinLabel = lbl;
            this.MeinRadioButton = RB;
            LabelAktualisieren();
        }
        public void LabelAktualisieren()
        {
            lblWetteaktualisieren();
            lblGeldaktualisieren();
        }
        public void lblWetteaktualisieren()
        {
            this.MeinLabel.Text = this.name + " wettet " + this.MeineWette.Betrag.ToString() + " auf Hund " + this.MeineWette.Hund.ToString();
        }
        public void lblGeldaktualisieren()
        {
            this.MeinRadioButton.Text = this.name + " hat " + this.Geld.ToString() + "€";
        }
        public void WetteLoeschen()
        {
            MeineWette.Betrag = MeineWette.Hund = 0;
        }
        public bool WetteAbgeben(int betrag, int hund)
        {
            if (betrag < Geld)
                if (betrag != 0 && hund != 0)
                {

                    MeineWette.Betrag = betrag;
                    MeineWette.Hund = hund;
                    Geld -= betrag;
                }
            return true;
        }
        public void Einkassieren(int sieger)
        {

            this.Geld += MeineWette.Auszahlen(sieger);
            WetteLoeschen();
            LabelAktualisieren();
        }
    }
}
