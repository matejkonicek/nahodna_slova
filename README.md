#Náhodná slova
Jedná se o jednoduchou konzolovou aplikaci, která generuje náhodná slova v konzoli. Uživatel zadá počet slov a počet písmen na řádek a aplikace náhodně generuje slova pomocí ASCII kódů písmen a vypisuje je v konzoli.

Tento program byl napsán v jazyce C# a využívá .NET framework.

#Jak program funguje
Po spuštění programu uživatel zadá počet slov, které se mají vygenerovat, a počet písmen v každém slově. Program náhodně generuje slova pomocí ASCII kódů písmen a následně je vypisuje v konzoli. Každé písmeno má náhodnou barvu, která se také vypisuje v konzoli.

#Popis kódu
Program obsahuje jednu třídu - Program. Tato třída obsahuje statickou metodu Main(), která je vstupním bodem programu. Zde jsou proměnné inicializovány, uživatel vyzván k zadání počtu slov a počtu písmen a následně jsou slova vygenerována a vypsána do konzole.

Významnější řádky kódu jsou:

const int AsciiStart = 97; a const int AsciiEnd = 122;: tyto konstanty určují ASCII kódy počátečního a koncového písmena v abecedě, které se používají k náhodnému generování písmen.

Random rnd = new Random();: tato řádka inicializuje instanci třídy Random, která se používá k náhodnému generování čísel a písmen.

pismena[x, y] = (char)rnd.Next(AsciiStart, AsciiEnd + 1);: tento řádek náhodně generuje písmeno pomocí ASCII kódů a ukládá ho do pole pismena.

Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);: tato řádka nastavuje náhodnou barvu výstupu.

Console.ReadLine();: tento řádek čeká na uživatelův vstup po vypsání slov.

#Jak program spustit
1. Stáhněte si zdrojový kód z repozitáře.
2. Otevřete projekt v IDE, které podporuje C# a .NET framework.
3. Sestavte projekt a spusťte program.
#Poznámky
Tento program slouží pouze pro demonstrační účely a nebyl otestován na širokém spe
