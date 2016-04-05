using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 23;
            Console.WriteLine(i++);
            Console.WriteLine(++i);
            Console.WriteLine(i+1 );

            i *= 7;
            Console.WriteLine(i);
            Console.WriteLine(i/100);
            Console.WriteLine(i%100);
            Console.ReadKey();
        }
    }
}
