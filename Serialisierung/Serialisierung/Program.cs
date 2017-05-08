using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung
{
    class Program
    {
        static bool running = true;
        static ArrayList perslist = new ArrayList();
        static void Main(string[] args)
        {
            while (running)
            {
                int eingabe = eingabeholen();
                switch (eingabe)
                {
                    case 1:
                        perslist.Add(perseingabe());
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        Console.WriteLine("keine valide option");
                        break;
                    default:
                        break;
                }
            }
        }

        private static int eingabeholen()
        {
            int[] opt = new int[] { 1, 2, 3 };
            int read = 0;
            Console.WriteLine("Wählen sie eine Alternative:");
            Console.WriteLine("1: eingabe");
            Console.WriteLine("2: ausgabe");
            Console.WriteLine("3: suche");
            int.TryParse(Console.ReadLine(), out read);
            if (opt.Contains(read))
            {
                return read;
            }
            return 0;
        }

        private static Person perseingabe()
        {
            Person outPers = new Person();
            outPers.personennr = (uint)(perslist.Count);
            Console.WriteLine("geben sie einen Vornamen ein");
            outPers.vorname = Console.ReadLine();
            Console.WriteLine("geben sie einen Nachnamen ein");
            outPers.nachname = Console.ReadLine();
            Console.WriteLine("geben sie eine emailadresse ein");
            outPers.email = Console.ReadLine();
            Console.WriteLine("geben sie eine telefonnummer ein");
            outPers.tel = Console.ReadLine();
            Console.WriteLine("geben sie ein alter ein");
            uint.TryParse(Console.ReadLine(), out uint alter);
            outPers.alter = alter;
            return outPers;
        }
    }
}