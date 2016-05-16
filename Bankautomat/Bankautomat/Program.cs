using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Wechseln();
                Console.ReadKey();
            }
        }

        static void alt_Wechseln()
        {
            double zahlbar = 0;
            double gezahlt = 0.0;


            Console.WriteLine("geben sie ihren zu zahlenden betrag ein");

            double.TryParse(Console.ReadLine(), out zahlbar);

        pin: Console.WriteLine("geben sie ihren gezahlten betrag ein");
            double.TryParse(Console.ReadLine(), out gezahlt);

            if (gezahlt <= zahlbar)
            {
                Console.WriteLine("es fehlt noch geld");
                goto pin;
            }
            else {

                gezahlt -= zahlbar;
            }

            Console.WriteLine("Dífferenz: " + gezahlt);
            double scheine50 = gezahlt / 50.0;
            double scheine20 = gezahlt % 50.0;
            double scheine10 = scheine20 % 20.0;
            double scheine5 = scheine10 % 10.0;
            double muenze2 = scheine5 % 5.0;
            double muenze1 = muenze2 % 2.0;
            double muenze05 = muenze1 % 1.0;
            double muenze02 = muenze05 % 0.5;
            double muenze01 = muenze02 % 0.2;
            double muenze005 = muenze01 % 0.1;
            double muenze002 = muenze005 % 0.05;
            double muenze001 = muenze002 % 0.02;

            Console.WriteLine("50er " + Convert.ToInt32(scheine50));
            Console.WriteLine("20er " + Convert.ToInt32(scheine20 / 20));
            Console.WriteLine("10er " + Convert.ToInt32(scheine10 / 10));
            Console.WriteLine("5er " + Convert.ToInt32(scheine5 / 5));
            Console.WriteLine("2er " + Convert.ToInt32(muenze2 / 2));
            Console.WriteLine("1er " + Convert.ToInt32(muenze1));
            Console.WriteLine("0,5er " + Convert.ToInt32(muenze05 / 0.5));
            Console.WriteLine("0,2er " + Convert.ToInt32(muenze02 / 0.2));
            Console.WriteLine("0,1er " + Convert.ToInt32(muenze01 / 0.1));
            Console.WriteLine("0,05er " + Convert.ToInt32(muenze005 / 0.05));
            Console.WriteLine("0,02er " + Convert.ToInt32(muenze002 / 0.02));
            Console.WriteLine("0,01er " + Convert.ToInt32(muenze001 / 0.01));
            Console.ReadKey();
        }

        static void Wechseln()
        {
            double zuZahlen;
            double gezahlt;
            double wechselgeld;

            int anz50, anz20, anz10, anz5, anz2, anz1, anz05, anz02, anz01, anz005, anz002, anz001 = 0;

            Console.Write("Zu Zahlen: ");
            Double.TryParse(Console.ReadLine(), out zuZahlen);
        pin: Console.Write("Gezahlt: ");
            Double.TryParse(Console.ReadLine(), out gezahlt);
            if (gezahlt >= zuZahlen)
            {
                wechselgeld = gezahlt - zuZahlen;
            }
            else {
                Console.WriteLine("Der Betrag ist zu niedrig!");
                Console.ReadKey();
                goto pin;
            }

            anz50 = (int)wechselgeld / 50;
            wechselgeld %= 50;
            anz20 = (int)wechselgeld / 20;
            wechselgeld %= 20;
            anz10 = (int)wechselgeld / 10;
            wechselgeld %= 10;
            anz5 = (int)wechselgeld / 5;
            wechselgeld %= 5;
            anz2 = (int)wechselgeld / 2;
            wechselgeld %= 2;
            anz1 = (int)wechselgeld / 1;
            wechselgeld %= 1.0;
            anz05 =(int)(wechselgeld/0.5);
            wechselgeld %= 0.5;
            anz02 = (int)(wechselgeld / 0.2);
            wechselgeld %= 0.2;
            anz01 = (int)(wechselgeld / 0.1);
            wechselgeld %= 0.1;
            anz005 = (int)(wechselgeld / 0.05);
            wechselgeld %= 0.05;
            anz002 = (int)(wechselgeld / 0.02);
            wechselgeld %= 0.02;
            anz001 = (int)(wechselgeld / 0.01);

            Console.WriteLine("50er " + anz50);
            Console.WriteLine("20er " + anz20);
            Console.WriteLine("10er " + anz10);
            Console.WriteLine("5er " + anz5);
            Console.WriteLine("2er " + anz2);
            Console.WriteLine("1er " + anz1);
            Console.WriteLine("05er " + anz05);
            Console.WriteLine("02er " + anz02);
            Console.WriteLine("01er " + anz01);
            Console.WriteLine("005er " + anz005);
            Console.WriteLine("002er " + anz002);
            Console.WriteLine("001er " +anz001);

        }
    }
}
