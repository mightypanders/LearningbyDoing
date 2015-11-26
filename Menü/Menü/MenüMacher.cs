using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menü
{
    class MenüMacher
    {
        public Random Zufallszahl;

        string[] Fleisch = { "Roastbeef", "Salami", "Pute", "Speck", "Braten" };
        string[] Soßen = { "Süßer Senf", "Scharfer Senf", "Ketchup", "Mayo", "Aioli", "Remoulade" };
        string[] Brot = { "Graubrot", "Weißbrot", "Toast", "Pumpernickel", "Ciabatta", "Brötchen" };


        public string MenüEintragHolen()
        {
            string zFleisch = Fleisch[Zufallszahl.Next(Fleisch.Length)];
            string zSoße = Soßen[Zufallszahl.Next(Soßen.Length)];
            string zBrot = Brot[Zufallszahl.Next(Brot.Length)];
            string menÜ = zFleisch + " mit " + zSoße + " auf " + zBrot;
            return menÜ;
        }
    }
}
