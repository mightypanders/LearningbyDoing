using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juwelendieb
{
    class Program
    {
        static void Main(string[] args)
        {
            Besitzer besitzer = new Besitzer();
            Safe safe = new Safe();
            Dieb dieb = new Dieb();
            dieb.SafeOeffnen(safe, besitzer);
            Console.ReadKey();
        }
    }
}
