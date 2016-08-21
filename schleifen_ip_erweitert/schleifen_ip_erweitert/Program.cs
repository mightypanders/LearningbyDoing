using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schleifen_ip_erweitert
{
    class Program
    {
        static void Main(string[] args)

        {

            int[][] bytes = new int[4][];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = new int[2];
            }

            int addressbyte = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                int aWert, eWert = 0;
                bool eingabefalsch = false;
                do
                {
                    Console.WriteLine("geben sie den Anfangswert des " + (i + 1) + ". Adressblocks ein.");
                    Int32.TryParse(Console.ReadLine(), out aWert);
                    if (aWert <= 255 && aWert >= 0)
                    {
                        bytes[i][0] = aWert;
                        eingabefalsch = false;
                    }
                    else
                        eingabefalsch = true;
                } while (eingabefalsch);
                do
                {
                    Console.WriteLine("geben sie den Endwert des " + (i + 1) + ". Adressblocks ein.");
                    Int32.TryParse(Console.ReadLine(), out eWert);
                    if (eWert <= 255 && eWert >= 0 && eWert >= aWert)
                    {
                        bytes[i][1] = eWert;
                        eingabefalsch = false;
                    }
                    else
                        eingabefalsch = true;
                } while (eingabefalsch);
            }
            Console.ReadKey();

        }
    }
}
