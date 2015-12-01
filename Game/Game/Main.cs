using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameControls;
using Game;

namespace Game
{
    class MainLoop
    {
        static gamestate GS;
        static Logic logic;
        static short Playercount = 4;

        static void Main(string[] args)
        {
            GS = new gamestate();
            Identifier MainID = new Identifier();
            Init init = new Init();
            logic = new Logic(3);
            init.PlayersInit(Playercount);
            gameloop();

        }

        static void gameloop()
        {
            while (GS.state)
            {
                logic.LoopStep();

            }
        }
       
    }
}
