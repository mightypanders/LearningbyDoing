using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayspointerundstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] testarr2d = new int[4, 4];
            for (int i = 0; i < testarr2d.GetLength(0); i++)
            {
                for (int j = 0; j < testarr2d.GetLength(1); j++)
                {
                    testarr2d[i, j] = r.Next();
                }
            }
            int[,,] testarr3d = new int[4, 4, 4];
            for (int i = 0; i < testarr3d.GetLength(0); i++)
            {
                for (int j = 0; j < testarr3d.GetLength(1); j++)
                {
                    for (int k = 0; k < testarr3d.GetLength(2); k++)
                    {
                        testarr3d[i, j, k] = r.Next();

                    }
                }
            }
            smallest2d(testarr2d);
            biggest3d(testarr3d);
        }
        static void smallest2d(int[,] testarr2d)
        {
            int smallest = int.MaxValue;
            int biggest = int.MinValue;
            Tuple<int, int> posSmall = new Tuple<int, int>(0, 0);
            Tuple<int, int> posBig = new Tuple<int, int>(0, 0);
            for (int i = 0; i < testarr2d.GetLength(0); i++)
            {
                for (int j = 0; j < testarr2d.GetLength(1); j++)
                {
                    if (testarr2d[i, j] < smallest)
                    {
                        smallest = testarr2d[i, j];
                        posSmall = new Tuple<int, int>(i, j);
                    }
                    if (testarr2d[i, j] > biggest)
                    {
                        biggest = testarr2d[i, j];
                        posBig = new Tuple<int, int>(i, j);
                    }
                }
            }

            Console.WriteLine("Position kleinster" + posSmall);
            Console.WriteLine("Position größter" + posBig);
            Console.ReadKey();
        }
        static void biggest3d(int[,,] testarr3d)
        {
            int smallest = int.MaxValue;
            int biggest = int.MinValue;
            Tuple<int, int, int> posSmall = new Tuple<int, int, int>(0, 0, 0);
            Tuple<int, int, int> posBig = new Tuple<int, int, int>(0, 0, 0);
            for (int i = 0; i < testarr3d.GetLength(0); i++)
            {
                for (int j = 0; j < testarr3d.GetLength(1); j++)
                {
                    for (int k = 0; k < testarr3d.GetLength(2); k++)
                    {

                        if (testarr3d[i, j, k] < smallest)
                        {
                            smallest = testarr3d[i, j, k];
                            posSmall = new Tuple<int, int, int>(i, j, k);
                        }
                        if (testarr3d[i, j, k] > biggest)
                        {
                            biggest = testarr3d[i, j, k];
                            posBig = new Tuple<int, int, int>(i, j, k);
                        }
                    }
                }
            }
            Console.WriteLine("Position kleinster" + posSmall);
            Console.WriteLine("Position größter" + posBig);
            Console.ReadKey();
        }
    }
}
