using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var employesOvertime = double.Parse(Console.ReadLine());

            var employesOnWork = days * 0.9 *8;
            var overtimeHours = employesOvertime*2*days ;
            var workingHours = employesOnWork + overtimeHours;
            if (neededHours<=workingHours)
            {
                Console.WriteLine($"Yes!{Math.Floor(workingHours-neededHours)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Abs(Math.Floor(workingHours-neededHours))} hours needed.");
            }
        }
    }
}
