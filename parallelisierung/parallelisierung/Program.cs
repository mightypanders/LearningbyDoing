using System;
using System.Threading;
namespace parallelisierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = thread1();
            Thread s = thread2();
            t.Start();
            s.Start();
        }

        static Thread thread1()
        {
            Thread t1 = new Thread(delegate ()
             {
                 while (true)
                 {
                     Console.Write("Hello, ");
                     Console.WriteLine("World!");
                     Thread.Sleep(100);
                     Console.WriteLine("Second Coming");
                 }
             });
            return t1;
        }
        static Thread thread2()
        {
            Thread t2 = new Thread(delegate ()
            {
                while (true)
                {
                    Console.WriteLine("Second Thread reporting in");
                    Thread.Sleep(100);
                    Console.WriteLine("Second Thread reportin out");
                }
            });
            return t2;
        }
    }
}