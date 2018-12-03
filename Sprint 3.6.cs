using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef hier je naam en voornaam! Geef daaronder je student nummer");
            string naam, nummer;
            naam = Console.ReadLine();
            nummer = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Naam: " + naam);
            Console.WriteLine("Student nummer: " + nummer);
            Console.WriteLine("---------------------------------------------------------------");

            Console.Write("Cijfer voor NED: ");
            double cijfer1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cijfer voor ENG: ");
            double cijfer2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cijfer voor WIS: ");
            double cijfer3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cijfer voor PRG: ");
            double cijfer4 = Convert.ToDouble(Console.ReadLine());
            double totaal = cijfer4 * 2;

            Console.Write("Cijfer voor DBD: ");
            double cijfer5 = Convert.ToDouble(Console.ReadLine());
            double totaal1 = cijfer5 * 2;

            Console.Write("Cijfer voor ALG: ");
            double cijfer6 = Convert.ToDouble(Console.ReadLine());
            double totaal2 = cijfer6 * 2;

            double totalecijfers = (cijfer1 + cijfer2 + cijfer3 + totaal + totaal1 + totaal2) / 9;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Dit is je gemiddelde: " + Math.Round(totalecijfers, 1));
            Console.ReadKey();
        }
    }
}
