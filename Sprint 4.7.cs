using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DayOfWeek today = DateTime.Today.DayOfWeek;

            Console.WriteLine("Is het een werkdag of weekend?");
            Console.WriteLine("------------------------------");
            Console.WriteLine(today);
            Console.WriteLine("------------------------------");

            if ((now.Hour > 0 && now.Hour < 12) && (today == DayOfWeek.Monday || today == DayOfWeek.Tuesday || today == DayOfWeek.Wednesday ||
                today == DayOfWeek.Thursday || today == DayOfWeek.Friday))
            {
                Console.WriteLine("Goedemorgen, het is een werkdag!");
            }
            if ((now.Hour > 12 && now.Hour < 18) && (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday))
            {
                Console.WriteLine("Goedemiddag, het is weekend!");
            }
            if ((now.Hour > 18 && now.Hour < 24) && (today == DayOfWeek.Monday || today == DayOfWeek.Tuesday || today == DayOfWeek.Wednesday ||
                                today == DayOfWeek.Thursday || today == DayOfWeek.Friday))
            {
                Console.WriteLine("Goedeavond, het is een werkdag!");
            }
            else
            {
                Console.WriteLine("Invalid Time...");
            }
            
            Console.ReadKey();
        }
    }
}
