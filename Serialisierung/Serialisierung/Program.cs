using System;
using System.Collections;
using System.Linq;

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
                        allepersonenausgeben();
                        break;
                    case 3:
                        Person suche = suchePerson();
                        personausgeben(suche);
                        break;
                    case 4:
                        running = false;
                        break;
                    case 0:
                        Console.WriteLine("keine valide option");
                        break;
                    default:
                        break;
                }
            }
        }

        private static Person suchePerson()
        {
            Console.WriteLine("geben sie den zu suchenden nachnamen ein:");
            String suchname = Console.ReadLine();
            if (!String.IsNullOrEmpty(suchname))
                foreach (Person item in perslist)
                    if (item.nachname.Contains(suchname))
                        return item;
            return new Person();
        }

        private static void personausgeben(Person item)
        {
            if (item.nachname != null)
                Console.WriteLine(item.vorname + " / " + item.nachname + " / " + item.email + " / " + item.tel + " / " + item.alter);
            else
                Console.WriteLine("Kann keine Person ausgeben");
        }

        private static void allepersonenausgeben()
        {
            foreach (Person item in perslist)
                personausgeben(item);
        }

        private static int eingabeholen()
        {
            int[] opt = new int[] { 1, 2, 3, 4 };
            int read = 0;
            Console.WriteLine("Wählen sie eine Alternative:");
            Console.WriteLine("1: eingabe");
            Console.WriteLine("2: ausgabe");
            Console.WriteLine("3: suche");
            Console.WriteLine("4: beenden");
            int.TryParse(Console.ReadLine(), out read);
            if (opt.Contains(read))
                return read;
            return 0;
        }

        private static Person perseingabe()
        {
            Console.Clear();
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