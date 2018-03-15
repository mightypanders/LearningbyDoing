﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiesitze
{
    class Program
    {
        public static bool[,] kino = new bool[,] { { false, false, false }, { false, true, true }, { true, true, true } };
        static void Main(string[] args)
        {
            Console.WriteLine(freieSitze(2));
            Console.WriteLine(freieSitze(3));

            Console.ReadKey();
        }
        public static int freieSitze(int anzahlSitze)
        {
            bool found = false;
            int ersterSitz = 0;
            if (anzahlSitze > 0)
            {
                int sitzZahl = 0;
                for (int reihe = 0; reihe < kino.GetLength(0); reihe++)
                {
                    if (!found)
                    {
                        ersterSitz = 0;
                        sitzZahl = 0;
                        for (int sitz = 0; sitz < kino.GetLength(1); sitz++)
                        {
                            if (!found)
                            {

                                if (kino[reihe, sitz])
                                {
                                    if (ersterSitz == 0)
                                    {
                                        ersterSitz = ((reihe + 1) * 100) + sitz + 1;
                                        sitzZahl = 1;
                                    }
                                    else
                                    {
                                        sitzZahl++;
                                    }
                                    if (sitzZahl >= anzahlSitze)
                                        found = true;

                                }
                                else
                                {
                                    ersterSitz = 0;
                                    sitzZahl = 0;
                                }
                            }
                            else break;
                        }

                    }
                    else break;
                }

            }
            else
            {
                ersterSitz = 0;
            }

            return ersterSitz;
        }
    }
}
