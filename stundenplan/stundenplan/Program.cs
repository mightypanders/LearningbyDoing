using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stundenplan
{
    class Tag
    {
        string wochentag;
        Stunde _s1;
        Stunde _s2;
        Stunde _s3;
        Stunde _s4;
        Stunde _s5;
        Stunde _s6;
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
            
            
}
    class Stunde 
    {   
        #region Member
        private string _fach;
        private string _lehrer;
        private string _raum;
        #endregion
        public Stunde(string fach, string lehrer, string raum) 
        {
            _fach = fach;
            _lehrer = lehrer;
            _raum = raum;
        }
        public void druckeStunde()
        {
            Console.WriteLine("________");
            Console.WriteLine(_fach);
            Console.WriteLine(_lehrer);
            Console.WriteLine(_raum);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stunde AW = new Stunde("AW","Wittek","HNN 106");
            Stunde IT = new Stunde("IT", "Forck", "HNE 303");
            Stunde WG = new Stunde("WG", "Wingold", "HNE 202");
           
            
            
            Console.WriteLine("________");
            Console.ReadKey();
        }
    }
}
