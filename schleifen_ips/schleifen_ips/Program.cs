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
            int ip_start = 23;
            int ip_ende = 42;
            string base_ip = "192.168.0.";





            for (int i = ip_start; i <= ip_ende; i++)
            {
                Console.WriteLine(base_ip + i.ToString());
            }
            Console.ReadKey();
        }
    }
}
