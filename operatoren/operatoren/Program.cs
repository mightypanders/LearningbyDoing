using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 23;
            Console.WriteLine(i++);
            Console.WriteLine(++i);
            Console.WriteLine(i+1);
            Console.WriteLine(i);

            i *= 7;

            Console.WriteLine(i);
            Console.WriteLine(i/100);
            Console.WriteLine(i%100);

            Console.ReadKey();
        }
    }
}
