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
            Init init = new Init();
            GS = new gamestate();
            Identifier ID = init.IDInit();            
            logic = new Logic();
            init.PlayersInit(Playercount, ID);
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
