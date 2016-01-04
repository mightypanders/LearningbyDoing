using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stundenplan
{
    class Tag
    {
        #region member
        string wochentag;
        Stunde[] Stundenarray = new Stunde[6];

        #region obsoleted
        //Stunde _s1;
        //Stunde _s2;
        //Stunde _s3;
        //Stunde _s4;
        //Stunde _s5;
        //Stunde _s6;
        #endregion

        #endregion

        #region Konstruktoren
        public Tag(string WT, Stunde[] arr)
        {
            wochentag = WT;
            Stundenarray = arr;
        }
        public Tag(string WT, Stunde s1, Stunde s2, Stunde s3, Stunde s4, Stunde s5, Stunde s6)
        {
            wochentag = WT;
            Stundenarray[0] = s1;
            Stundenarray[1] = s2;
            Stundenarray[2] = s3;
            Stundenarray[3] = s4;
            Stundenarray[4] = s5;
            Stundenarray[5] = s6;
        }
        #endregion

        #region funktionen
        public void Tagausgeben()
        {
            Console.WriteLine(wochentag);
            for (int i = 0; i < Stundenarray.Length; i++)
            {
                Stundenarray[i].druckeStunde();

            }
            Console.WriteLine(" ");
        }
        #endregion

    }
    class Stunde
    {
        #region Member
        private string _fach;
        private string _lehrer;
        private string _raum;
        #endregion

        #region Konstruktor
        public Stunde(string fach, string lehrer, string raum)
        {
            _fach = fach;
            _lehrer = lehrer;
            _raum = raum;
        }
        #endregion

        #region funktionen
        public void druckeStunde()
        {
            //Console.WriteLine("________");
            Console.WriteLine(_fach + " " + _raum + " " + _lehrer);
            //Console.WriteLine(_lehrer);
            //Console.WriteLine(_raum);

        }
        #endregion
    }
    class Woche
    {
        #region Member
        int Wochennummer;
        Tag[] Tagesarray;
        #endregion

        #region Konstruktoren
        public Woche(int Wochennummer, Tag[] Tagesarray)
        {
            this.Wochennummer = Wochennummer;
            this.Tagesarray = Tagesarray;
        }

        #endregion

        #region Methoden

        public void WocheDrucken()
        {
            for (int i = 0; i < Tagesarray.Length; i++)
            {
                Tagesarray[i].Tagausgeben();
            }
        }
        #endregion
    }
    class Program
    {

        static Stunde AW = new Stunde("AW", "Wittek", "HNN 106");
        static Stunde IT = new Stunde("IT", "Forck", "HNE 303");
        static Stunde WGW = new Stunde("WG", "Wingold", "HNE 202");
        static Stunde WGA = new Stunde("WG", "Abel", "HNE 205");
        static Stunde DE = new Stunde("DE", "Trieber-Schreyer", "HNN 202");
        static Stunde REL = new Stunde("RE", "Hinz", "HNN 206");
        static Stunde WGE = new Stunde("WG", "Engels", "HNE 303");
        static Stunde EN = new Stunde("EN", "Mühlenhoff", "HNE 203");


        static void Main(string[] args)
        {
            Tag[] Tage = TageAnlegen();
            Woche W = new Woche(1, Tage);
            W.WocheDrucken();
            //Tag mit = new Tag("Mittwoch",)

            Console.ReadKey();
        }
        public static Tag[] TageAnlegen()
        {
            Tag[] Tage = new Tag[5];
            Tage[0] = new Tag("Montag", AW, AW, IT, WGW, WGW, WGW);
            Tage[1] = new Tag("Dienstag", IT, IT, DE, DE, WGA, WGA);
            Tage[2] = new Tag("Mittwoch", IT, IT, DE, DE, WGA, WGA);
            Tage[3] = new Tag("Donnerstag", AW, AW, IT, WGW, WGW, WGW);
            Tage[4] = new Tag("Freitag", IT, IT, DE, DE, WGA, WGA);
            return Tage;
        }

    }
}
