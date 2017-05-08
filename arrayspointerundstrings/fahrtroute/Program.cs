using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrtroute
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] d ={ { 0, 10, 20 }, { 10, 0, 15 }, { 20, 15, 0 } };
            int[] r = { 4, 2, 1, 2, 0 };
            int entf = 0;
            for (int i = 1; i < r[0]; i++)
            {
                entf += d[r[i], r[i + 1]];
            }
            Console.WriteLine(entf);
            Console.ReadKey();
        }
    }
}
