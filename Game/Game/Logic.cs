using System;
using GameControls;

namespace Game
{
    class Logic
    {

        public Logic()
        {

        }

        public void LoopStep()
        {
            Console.WriteLine("Weiter?");
            if (Console.ReadLine().Equals("y"))
            {
                foreach (Player p in Init.playArr)
                {
                    Console.WriteLine(p.name + " " + p.uID +" "+ p.playernumber);
                }
                Console.WriteLine();
            }
        }
    }
}
