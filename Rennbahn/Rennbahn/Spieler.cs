﻿using System;
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

        public Spieler(string name, int nummer, Wette MeineWette, int Geld)
        {
            this.name = name;
            this.MeineWette = MeineWette;
            this.Geld = Geld;
        }

        public void LabelAktualisieren()
        {
            Form1.spLabelaktualisieren(this);
        }
        public void WetteLoeschen()
        {

        }
        public bool WetteAbgeben(int betrag, int hund)
        {
            if (betrag < Geld)
                if (betrag != 0 && hund != 0)
                {
                    MeineWette.Betrag = betrag;
                    MeineWette.Hund = hund;
                }
            return true;
        }
        public void Einkassieren(int sieger)
        {

        }
    }
}