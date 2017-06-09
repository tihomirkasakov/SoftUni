using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsToHomeTown = int.Parse(Console.ReadLine());
            var yw = 48;
            var Sofia = 48 - weekendsToHomeTown;
            var gamesPlayedInSofia = (3.0 / 4 * Sofia) + (2.0 / 3 * holidays);
            if(yearType=="leap")
            {
                Console.WriteLine(Math.Truncate((gamesPlayedInSofia+weekendsToHomeTown)*1.15));
            }
            else if(yearType=="normal")
            {
                Console.WriteLine(Math.Truncate(gamesPlayedInSofia+weekendsToHomeTown));
            }
        }
    }
}
