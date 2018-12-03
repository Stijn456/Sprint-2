using System;
using System.Diagnostics;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    class Program
    {
         static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();

            Console.WriteLine("In hoeveel seconden kan jij de gegevens in vullen?");
            string naam, leeftijd;
            Console.Write("Geef je naam (ook achternaam): ");
            naam = Console.ReadLine();
            Console.Write("Geef je leeftijd: ");
            leeftijd = Console.ReadLine();

            watch.Stop();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("je hebt het in " + watch.Elapsed + (" seconden gedaan"));
            Console.ReadKey();
        }
    }
}
