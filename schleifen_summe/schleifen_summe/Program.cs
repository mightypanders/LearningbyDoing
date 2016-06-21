using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schleifen_summe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geben sie einen Startwert ein: ");
            int startwert = 0;
            Int32.TryParse(Console.ReadLine(), out startwert);
            Console.WriteLine("geben sie einen Endwert ein: ");
            int endwert = 0;
            int summe = 0;
            Int32.TryParse(Console.ReadLine(), out endwert);
            for (int i = startwert; i <= endwert; i++)
            {
                summe += i;
            }
            Console.WriteLine("Die summe ist: " + summe);
            Console.ReadKey();
        }
    }
}
