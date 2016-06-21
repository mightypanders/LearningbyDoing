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

            Console.WriteLine("geben sie einen wert ein: ");
            int endwert = 0;
            int summe = 0;
            Int32.TryParse(Console.ReadLine(), out endwert);

            for (int i = 0; i <= endwert; i++)
            {
                summe += i;
            }

            Console.WriteLine("Die summe ist: " + summe);
            Console.ReadKey();
        }
    }
}
