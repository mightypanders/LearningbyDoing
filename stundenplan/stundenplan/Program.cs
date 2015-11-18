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
        Stunde _s1;
        Stunde _s2;
        Stunde _s3;
        Stunde _s4;
        Stunde _s5;
        Stunde _s6;
        #endregion

        #region Konstruktoren
        public Tag (string WT, Stunde[] arr)
        {
            wochentag = WT;
            Stundenarray = arr;
        }
        public Tag (string WT, Stunde s1, Stunde s2, Stunde s3, Stunde s4, Stunde s5, Stunde s6)
        {
            wochentag = WT;
            _s1 = s1;
            _s2 = s2;
            _s3 = s3;
            _s4 = s4;
            _s5 = s5;
            _s6 = s6;
        }
        #endregion

        #region funktionen
        public void Tagausgeben()
        {
            Console.WriteLine(wochentag);
            _s1.druckeStunde();
            _s2.druckeStunde();
            _s3.druckeStunde();
            _s4.druckeStunde();
            _s5.druckeStunde();
            _s6.druckeStunde();
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
            Console.WriteLine("________");
            Console.WriteLine(_fach);
            Console.WriteLine(_lehrer);
            Console.WriteLine(_raum);
            
        }
        #endregion
    }

    class Program
    {
       
        static Stunde AW = new Stunde("AW", "Wittek", "HNN 106");
        static Stunde IT = new Stunde("IT", "Forck", "HNE 303");
        static Stunde WGW = new Stunde("WG", "Wingold", "HNE 202");
        static Stunde WGA = new Stunde("WG", "Abel", "HNE205");
        static Stunde DE = new Stunde("DE", "Trieber-Schreyer", "HNN202");
        static Stunde REL = new Stunde("REL", "Hinz", "HNN206");
        static Stunde WGE = new Stunde("WGE", "Engels", "HNE303");
        static Stunde EN = new Stunde("EN", "Mühlenhoff", "HNE203");


        static void Main(string[] args)
        {
           
            Tag mon = new Tag("Montag", AW, AW, IT, WGW, WGW, WGW);
            Tag die = new Tag("Dienstag", IT, IT, DE, DE, WGA, WGA);
            WocheAusgeben(mon, die);
            Console.ReadKey();          
        } 

        public static void WocheAusgeben(Tag mon, Tag die)
        {
            mon.Tagausgeben();
            die.Tagausgeben();
            return;
        }
    }
}
