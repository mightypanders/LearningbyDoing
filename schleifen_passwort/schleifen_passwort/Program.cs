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
            string[] pw = { "abc", "def", "passwort", "Nixdorf" };
            int versuche = 0;

            do
            {
                Console.WriteLine("bitte geben sie ihr passwort ein :");
                eingabe = Console.ReadLine();
                foreach (string item in pw)
                {
                    if (eingabe.Equals(item))
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
                System.Threading.Thread.Sleep(3000);
                System.Environment.Exit(1);
            }else if (richtig)
            {
                Console.WriteLine("Das Passwort ist richtig");
                System.Threading.Thread.Sleep(3000);
                System.Environment.Exit(1);
            }
            Console.ReadKey();

        }
    }
}
