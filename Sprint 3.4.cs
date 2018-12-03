using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoeveel Euro wil je Wisselen");
            Console.Write("Hoeveel wilt u wisselen? (in euro's) € ");
            double euro = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            double pond = 0.8846;
            Console.WriteLine("Pond = 0,8846 / Typ: 1");
            double dollar = 1.1362;
            Console.WriteLine("Dollar = 1,1362 / Typ: 2");
            double canada = 1.4996;
            Console.WriteLine("Canadese Dollar = 1,4996 / Typ: 3");
            double yen = 128.665;
            Console.WriteLine("Japanse Yen = 128,665 / Typ 4");
            double frank = 1.1328;
            Console.WriteLine("Zwisterse Frank = 1,1328 / Typ 5");
            Console.ReadLine();
            Console.Write("Kies de gewenste valuta (tik nummer in): ");
            double kies = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            if (kies <= 1)
            {
                double totaal = euro * pond;
                Console.Write("Dit is wat je krijgt: " + Math.Round(totaal, 2) + " Pond");
            }
            else
                if (kies <= 2)
            {
                double totaal1 = euro * dollar;
                Console.Write("Dit is wat je krijgt: " + Math.Round(totaal1, 2) + " Dollar");
            }
            else
                if (kies <= 3)
            {
                double totaal2 = euro * canada;
                Console.Write("Dit is wat je krijgt: " + Math.Round(totaal2, 2) + " Canadese Dollar");
            }
            else
                if (kies <= 4)
            {
                double totaal3 = euro * yen;
                Console.Write("Dit is wat je krijgt: " + Math.Round(totaal3, 2) + " Japanse Yen");
            }
            else
                if(kies <=5)
            {
                double totaal4 = euro * frank;
                Console.Write("Dit is wat je krijgt: " + Math.Round(totaal4, 2) + " Zwisterse Frank");
            }


            Console.ReadKey();
            
            


        }
    }
}
