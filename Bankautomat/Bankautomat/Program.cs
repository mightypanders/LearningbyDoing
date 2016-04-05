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
            int aus_betrag = 0;

            Console.WriteLine("geben sie ihren betrag ein");

            int.TryParse(Console.ReadLine(),out aus_betrag);


            int scheine50 = aus_betrag / 50;
            int scheine20 = aus_betrag % 50;            
            int scheine10 = scheine20%20;
            int scheine5 = scheine10 % 10;
            int muenze2 = scheine5%5;
            int muenze1 = muenze2%2;

            Console.WriteLine(scheine50);
            Console.WriteLine(scheine20/20);
            Console.WriteLine(scheine10/10);
            Console.WriteLine(scheine5/5);
            Console.WriteLine(muenze2/2);
            Console.WriteLine(muenze1);
            Console.ReadKey();

        }
    }
}
