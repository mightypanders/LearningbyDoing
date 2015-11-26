using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameControls;

namespace Game
{
    class MainLoop
    {

        static void Main(string[] args)
        {
            gamestate GS = new gamestate();
            Identifier MainID = new Identifier();
            Init init = new Init();
            init.PlayersInit(3);
            while (GS.state)
            {

            }
        } 
    }
}
