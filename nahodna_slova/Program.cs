using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nahodna_slova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("zadej pocet slov");
            int Pocetslov = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zadej pocet písmen");
            int Pocetpismen = Convert.ToInt32(Console.ReadLine()); ;
            char[,] pismena = new char[Pocetslov, Pocetpismen];

            for (int x = 0; x < pismena.GetLength(0); x++)
            {
                for (int y = 0; y < pismena.GetLength(1); y++)
                {
                    pismena[x, y] = (char)rnd.Next(97, 122);
                }
            }

            for (int m = 0; m < pismena.GetLength(0); m++)
            {
                for (int n = 0; n < pismena.GetLength(1); n++)
                {
                    Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                    Console.Write(pismena[m, n] + "   ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }    
}
