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
        static bool convert = true;
        static string ergebnis = "";
        static int Zahl;
        static decimal Dec;
        static void Main(string[] args)
        {
            foreach (string item in arr)
            {
                try
                {
                    time = DateTime.Parse(item);
                    Console.WriteLine("DateTime " + time.ToString());
                    Console.ReadKey();
                    //continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("DateTime " + item + " verkackt");
                    Console.ReadKey();
                }
                try
                {
                    Zahl = int.Parse(item);
                    Console.WriteLine("Zahl " + Zahl);
                    Console.ReadKey();
                    //continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Zahl " + item + " verkackt");
                    Console.ReadKey();
                }
                try
                {
                    //foreach (char i in item)
                    //{
                    //    try
                    //    {
                    //        Zahl = int.Parse(i.ToString());
                    //        convert = true;
                    //    }
                    //    catch (Exception)
                    //    {
                    //        convert = false;
                    //    }
                    //    if (convert)
                    //    {
                    //        ergebnis += Zahl.ToString();

                    //        continue;
                    //    }
                    //}
                    Decimal.TryParse(item, out Dec);

                    Console.WriteLine(Dec);

                }
                catch (Exception)
                {
                    Console.WriteLine("foreach");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }
    }
}

//experiment 1
//experiment 2
