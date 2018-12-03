using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal in: ");
            Double nummer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------");

            if (nummer < 2)
            {
                Console.WriteLine("Klaveren!");
            }
            else
                if (nummer < 3)
            {
                Console.WriteLine("Ruiten!");
            }
            else
                if (nummer < 4)
            {
                Console.WriteLine("Harten!");
            }
            else
                if (nummer < 5)
            {
                Console.WriteLine("Schoppen!");
            }
            else
                if(nummer >= 5)
            {
                Console.WriteLine("Geen geldige waarde!");
            }

            Console.ReadKey();
            
        }
    }
}
