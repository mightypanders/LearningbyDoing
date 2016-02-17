using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CateringKostenRechner
{
    class Abendessen : Party
    {
        public Abendessen(int Personen, bool trocken, bool exklusiv) : base(Personen)
        {
            TrockenerAbendWaehlen(trocken);
            DekokostenBerechnen(exklusiv);
        }
        public void TrockenerAbendWaehlen(bool gew)
        {
            if (gew)
            {
                GKproPers = 5M;
                Rabatt = 0.95M;
            }
            else
            {
                GKproPers = 20M;
                Rabatt = 1M;
            }
        }

        public override decimal KostenBerechnen()
        {
            Gesamtkosten = (Dekokosten + ((GKproPers + EssenskostenproPerson) * Personen)) * Rabatt;
            return Gesamtkosten;
        }
    }
    class Geburtstagsfeier : Party
    {
        private int kuchengroesse;
        //private bool exklusiveDeko;
        private string kuchentext;

        public Geburtstagsfeier(int Personen, bool exklusivDeko, string ktext) : base(Personen)
        {
            this.ExklusiveDeko = exklusivDeko;
            KuchengroesseBerechnen();
            this.Kuchentext = ktext;
            DekokostenBerechnen(ExklusiveDeko);
        }


        public int Kuchengroesse
        {
            get
            {
                return kuchengroesse;
            }

            set
            {
                kuchengroesse = value;
            }
        }

        public string Kuchentext
        {
            get
            {
                return this.kuchentext;
            }

            set
            {
                int maxL;
                if (kuchengroesse == 18)
                {
                    maxL = 28;
                }
                else
                {
                    maxL = 40;
                }
                if (value.Length > maxL)
                {
                    MessageBox.Show("Text zu lang für " + Kuchengroesse + "-cm-Kuchen.");
                    if (maxL > this.kuchentext.Length)
                        maxL = this.kuchentext.Length;
                    this.kuchentext = kuchentext.Substring(0, maxL);
                }
                else
                {
                    this.kuchentext = value;
                }
                kuchentext = value;
            }
        }
        private void KuchengroesseBerechnen()
        {
            if (Personen <= 4)
                Kuchengroesse = 18;
            else
                Kuchengroesse = 28;
        }

        public override decimal KostenBerechnen()
        {

            decimal KKosten;
            if (Kuchengroesse == 18)
                KKosten = 40M + Kuchentext.Length * .25M;
            else
                KKosten = 75M + Kuchentext.Length * .25M;


            return base.KostenBerechnen() + KKosten;
        }
    }
}
