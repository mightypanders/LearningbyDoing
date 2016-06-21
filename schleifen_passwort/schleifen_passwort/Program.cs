using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schleifen_passwort
{
    class Program
    {
        static void Main(string[] args)
        {
            bool richtig = false;
            string eingabe = "";
            string[] pw = { "abc", "def", "passwort" };
            int versuche = 0;

            do
            {
                Console.WriteLine("bitte geben sie ihr passwort ein :");
                eingabe = Console.ReadLine();
                foreach (string item in pw)
                {
                    if (eingabe == item)
                    {
                        richtig = true;
                    }
                    else
                    {
                        Console.WriteLine("das passwort ist falsch!");
                        versuche += 1;
                        break;
                    }
                }
                eingabe = "";
            } while (!richtig && versuche < 3);
            if (!richtig)
            {

                Console.WriteLine("Das Programm wird geschlossen!");

            }
            Console.ReadKey();

        }
    }
}
