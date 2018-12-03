using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef twee getallen");

            Console.Write("Typ getal 1: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("typ getal 2: ");
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------");

            Console.WriteLine("Optellen = type 1");
            Console.WriteLine("Aftrekken = type 2");
            Console.WriteLine("Vermenigvuldigen = type 3");
            Console.WriteLine("Delen = 4");
            Console.WriteLine("Module typ = 5");
            Console.WriteLine("-------------------------");
            Console.Write("Welke wil je kiezen: ");
            double getal3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------");

            if (getal2 < 0)
            {

            }

            if (getal3 <= 1)
            {
                double optellen = getal1 + getal2;
                Console.WriteLine("Antwoord = " + optellen);
            }
            else
                if (getal3 <= 2)
            {
                double aftrekken = getal1 - getal2;
                Console.WriteLine("Antwoord = " + aftrekken);
            }
            else
                if (getal3 <= 4)
            {
                double x = getal1 * getal2;
                Console.WriteLine("Antwoord = " + x);
            }
            else
                if (getal3 <= 5 && getal2 <= 0) 
            {
                double delen = getal1 / getal2;
                Console.WriteLine("Antwoord = " + delen);
            }
            
            



            Console.ReadKey();
        }
    }
}
