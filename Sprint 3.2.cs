using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2008, 8, 14);
            DateTime date2 = new DateTime(2008, 4, 24);
            TimeSpan timespan = date1.Subtract(date2);
            Console.WriteLine("There are {0} number of days between {1} and {2}", timespan.TotalDays, date1.ToShortDateString(), date2.ToShortDateString());
            Console.ReadLine();
        }
    }
}
