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
    class Init
    {
        Player[] playArr;
        Player temp;
        public void PlayersInit(short spielerzahl)
        { short nummer;
            playArr = new Player[spielerzahl];
            for (short i = 0; i < spielerzahl; i++)
            {
                nummer = (short)(i + 1);
                temp = new Player("", nummer , "", null, 1, 0, 0, 0, 0);
                playArr[i] = temp;
                temp = null;
            }
        }
#if DEBUG
        public void printPlayers()
        {
            for (int i = 0; i < playArr.Length; i++)
            {
                temp = playArr[i];
                Console.WriteLine(temp.playernumber);
            }
        }
#endif
    }
    
}
