using System;
using GameControls;
using Game;

namespace Game
{
    class MainLoop
    {
        static gamestate GS;
        static Logic logic;
        static short Playercount = 0;
        static Identifier ID;

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
            //Init init = new Init();
            ID = Init.IDInit();
            logic = new Logic();

            Playercount = Init.askPlayerCount();
            Init.PlayersInit(Playercount, ID);
            return true;
        }

    }
}
