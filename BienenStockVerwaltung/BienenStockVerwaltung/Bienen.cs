﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BienenStockVerwaltung
{
    public class Bienen
    {

    }
    public class Bienenkoenigin : Bienen
    {
        private Arbeitsbiene[] arbeiter;
        private int schichtNummer;

        public Bienenkoenigin(Arbeitsbiene[] arbeiter)
        {
            this.arbeiter = arbeiter;
        }

        public bool ArbeitZuweisen(string arbeit, int schichtanzahl)
        {
            bool gefunden = true;
            //true, wenn Arbeiterin gefunden, false wenn keine gefunden der die Arbeit zugewiesen werden kann.

            foreach (Arbeitsbiene b in arbeiter)
            {
                if (b.AufgabeErledigen(arbeit, schichtanzahl))
                {
                    gefunden = true;

                    break;
                }

            }

            return gefunden;
        }
        public string NaechsteSchichtArbeiten()
        {
            //jede Arbeiterin arbeitet eine Schicht -> Statuscheck bei allen -> Schichtbericht erweitert
            return "";
        }

    }
    public class Arbeitsbiene : Bienen
    {
        private string aktuelleArbeit = "";
        private int offeneSchichten;

        private string[] moeglicheArbeiten;
        private int schichtAnzahl;
        private int erledigteSchichten;

        #region properties

        public int OffeneSchichten
        {
            get
            {
                return offeneSchichten;
            }

            set
            {
                offeneSchichten = value;
            }
        }

        public string AktuelleArbeit
        {
            get
            {
                return aktuelleArbeit;
            }

            set
            {
                aktuelleArbeit = value;
            }
        }

        public string[] MoeglicheArbeiten
        {
            get
            {
                return moeglicheArbeiten;
            }

            set
            {
                moeglicheArbeiten = value;
            }
        }

        public int SchichtAnzahl
        {
            get
            {
                return schichtAnzahl;
            }

            set
            {
                schichtAnzahl = value;
            }
        }

        public int ErledigteSchichten
        {
            get
            {
                return erledigteSchichten;
            }

            set
            {
                erledigteSchichten = value;
            }
        }
        #endregion

        public Arbeitsbiene(string[] moeglicheArbeiten)
        {
            this.moeglicheArbeiten = moeglicheArbeiten;
        }

        public bool AufgabeErledigen(string arbeit, int schichten)
        {
            if (AktuelleArbeit != arbeit)
            {
                foreach (string a in moeglicheArbeiten)
                {
                    if (a.Equals(arbeit))
                    {
                        AktuelleArbeit = arbeit;
                        return true;
                    }
                }
                return false;
            }
            return true;
        }

    }
}