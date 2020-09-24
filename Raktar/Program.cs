﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {
        static List<Termek> termekek = new List<Termek>();
        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                /*
                 * sor[0]-> Kód
                 *  sor[1] -> Név
                 * sor[2] -> Ár
                 * sor[3] -> Darabszám
                 */
                 string[] sor = raktar.ReadLine().Split(';');
                
                Termek t = new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3]));
                termekek.Add(t);
            }
            raktar.Close();
        }
        static void Main(string[] args)
        {
            BeolvasRaktar();
            Console.ReadKey();
        }
    }
}
