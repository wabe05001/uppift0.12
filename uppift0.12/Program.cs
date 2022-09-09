using System;
namespace Uppgift_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge ska du hyra bilen");
            String bilenText = Console.ReadLine();
            int dagar = int.Parse(bilenText);
            Console.WriteLine("hur många kilometer ska du köra?");
            int kilometer = int.Parse(Console.ReadLine());
            int kostnad = 300 + 500 * (dagar - 1) + kilometer;
            int summa = kilometer + kostnad;
            int produkt = kilometer * kostnad;
            Console.WriteLine("Summan av talen är " + summa + " kr ");
            Console.WriteLine("Produkten av talen är " + produkt);
        }
    }
}