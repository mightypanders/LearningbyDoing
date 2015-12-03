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
        static short Playercount = 0;
        [MTAThread]
        static void Main(string[] args)
        {
            
            GS = new gamestate();
            initialize();
            
            gameloop();

        }

        static void gameloop()
        {
            while (GS.state)
            {
                logic.LoopStep();

            }
        }

        static bool initialize()
        {
            Init init = new Init();
            Identifier ID = init.IDInit();
            logic = new Logic();

            Playercount = init.askPlayerCount();
            init.PlayersInit(Playercount, ID);
            return true;
        }
       
    }
}
