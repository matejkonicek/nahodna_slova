using System;

// Vytvoření namespace nahodna_slova
namespace nahodna_slova
{
    // Vytvoření třídy Program s viditelností internal
    internal class Program
    {
        // Definice konstant s ASCII kódy pro písmena 'a' a 'z'
        const int AsciiStart = 97; // Počáteční hodnota ASCII kódu pro písmeno 'a'
        const int AsciiEnd = 122; // Koncová hodnota ASCII kódu pro písmeno 'z'
                                  // Hlavní metoda Main s parametrem string[] args
        static void Main(string[] args)
        {
            // Inicializace náhodného generátoru
            Random rnd = new Random();

            // Výpis výzvy pro zadání počtu slov a načtení hodnoty od uživatele
            Console.WriteLine("Zadej počet slov:");
            int Pocetslov;
            while (!int.TryParse(Console.ReadLine(), out Pocetslov))
            {
                Console.WriteLine("Neplatný vstup. Zadej celé číslo.");
            }

            // Výpis výzvy pro zadání počtu písmen a načtení hodnoty od uživatele
            Console.WriteLine("Zadej počet písmen:");
            int Pocetpismen;
            while (!int.TryParse(Console.ReadLine(), out Pocetpismen))
            {
                Console.WriteLine("Neplatný vstup. Zadej celé číslo.");
            }

            // Vytvoření dvourozměrného pole pismena s velikostí Pocetslov x Pocetpismen
            char[,] pismena = new char[Pocetslov, Pocetpismen];

            // Naplnění pole pismena náhodnými písmeny
            for (int x = 0; x < pismena.GetLength(0); x++)
            {
                for (int y = 0; y < pismena.GetLength(1); y++)
                {
                    pismena[x, y] = (char)rnd.Next(AsciiStart, AsciiEnd + 1); // Generování náhodného písmene
                }
            }

            // Výpis pole pismena do konzole
            for (int m = 0; m < pismena.GetLength(0); m++)
            {
                for (int n = 0; n < pismena.GetLength(1); n++)
                {
                    Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16); // Nastavení náhodné barvy výstupu
                    Console.Write(pismena[m, n] + "   ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            // Nastavení barvy konzole zpět na bílou a čekání na stisknutí klávesy Enter
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
