using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schleifen_ips
{
    class Program
    {
        static void Main(string[] args)
        {
            int ip_start = 0;
            int ip_ende = 0;
            string base_ip = "192.168.0.";


            Console.WriteLine("geben sie den start des adressbereichs ein: ");
            Int32.TryParse(Console.ReadLine(), out ip_start);

            Console.WriteLine("geben sie das ende des adressbereichs ein: ");
            Int32.TryParse(Console.ReadLine(), out ip_ende);

            if ((ip_start >= 0 && ip_start < ip_ende) && (ip_ende <= 255))
            {
                for (int i = ip_start; i <= ip_ende; i++)
                {
                    Console.WriteLine(base_ip + i.ToString());
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Der Adressbereich ist ungültig");
                Console.ReadKey();
            }
        }
    }
}
