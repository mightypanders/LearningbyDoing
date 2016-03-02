using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimente
{
    class Program
    {
        public static string a = "das ist ein Test";
        public static string b = "2016-02-26";
        public static string c = "26.2.2106";
        public static string d = "012.234.456.678";
        public static string[] arr = new string[] { a, b, c, d };
        static DateTime time;
        static int Zahl;
        static void Main(string[] args)
        {
            foreach (string item in arr)
            {
                try
                {
                    time = DateTime.Parse(item);
                    Console.WriteLine("DateTime " + time.ToString());
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("DateTime " + item + " verkackt");
                }
                try
                {
                    Zahl = int.Parse(item);
                    Console.WriteLine("Zahl " + Zahl);
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Zahl " + item + " verkackt");
                }
            }
        }
    }
}
