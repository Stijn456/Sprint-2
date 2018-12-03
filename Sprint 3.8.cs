using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_3._8_Goed
{
    class Program
    {
        public static object StaticRandom { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Maak hier je username!");
            Console.Write("Vul voornaam in: ");
            string String = Console.ReadLine();
            string Letter = String.Substring(0, 1);
            Console.Write("Vul je achternaam in: ");
            string achternaam = Console.ReadLine();

            int len = String.Length;
            int len2 = achternaam.Length;


            double len3 = len + len2;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(Letter + achternaam + len3);
            Console.WriteLine("----------------------------------------------------");
            Console.ReadKey();
     
        }
    }
}
