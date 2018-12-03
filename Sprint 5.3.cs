using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef getal 1: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef getal 2: ");
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------");

            for (double i = getal1; i < getal2 + 1; i++)
            {
                Console.Write("Regel: ");
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
