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

        static void Main(string[] args)
        {
            GS = new gamestate();
            Identifier MainID = new Identifier();
            Init init = new Init();
            init.PlayersInit(3);
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
