using System;
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
        static List<Megrendeles> rendelesek = new List<Megrendeles>();
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
        static void Rendelesolvas()
        {
            StreamReader olvas = new StreamReader("rendeles.csv");
            while (!olvas.EndOfStream)
            {
                string[] sor = olvas.ReadLine().Split(';');

                if (sor[0] == "M")
                {
                    rendelesek.Add(new Megrendeles(sor[1], sor[2], sor[3]));
                }
            }
            olvas.Close();
        }
        static void Main(string[] args)
        {

            //BeolvasRaktar();
            /*foreach (var t in termekek)
            {
                Console.WriteLine(t.NEV);
            }*/
            
            Rendelesolvas();

            foreach (var i in rendelesek)
            {
                Console.Write($"{i.DATUM} {i.RENDELESSZAM} {i.EMAIL}");
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
