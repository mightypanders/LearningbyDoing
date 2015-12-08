using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;

namespace GameControls
{
    class Identifier
    {
        protected int globalID = 0;

        public int getuID()
        {
            globalID++;
            return globalID;
        }
    }
    class gamestate
    {
        protected bool _state = true;
       
        public bool state
        {
            get { return _state; }
            set { _state = value; }
        }
    }
    static class Init
    {
       static Player[] playArr;
        static Player temp;
        public static void PlayersInit(short spielerzahl, Identifier ID)
        {
            string pcolor="";
            string pname="";
            short nummer=0;
            playArr = new Player[spielerzahl];
            for (short i = 0; i < spielerzahl; i++)
            {
                nummer = (short)(i + 1);
                pname = askPlayername(nummer);
                pcolor = askColor(nummer);

                temp = new Player(ID,pname, nummer , pcolor, null, 1, 0, 0, 0, 0);
                playArr[i] = temp;
                temp = null;
            }
        }
        public static Identifier IDInit()
        {
            Identifier ID = new Identifier();
            return ID;
        }

        public static string askPlayername(short Pnumber)
        {
            Console.WriteLine("Bitte geben sie einen Namen für Spieler"+Pnumber+" ein");
            string pname = Console.ReadLine();
            return pname;
        }
        public static string askColor(short Pnumber)
        {
            Console.WriteLine("Bitte geben sie eine Farbe für Spieler"+Pnumber+" ein");
            string pcolor = Console.ReadLine();
            return pcolor;
        }

        public static short askPlayerCount()
        {
            Console.WriteLine("Bitte geben sie an wie viele Spieler teilnehmen.");
            short pcount = short.Parse(Console.ReadLine());
            return pcount;
        }
    }
    
}
