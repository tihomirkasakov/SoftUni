using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var areaOfHouse = double.Parse(Console.ReadLine());
            var numberOfWindows = int.Parse(Console.ReadLine());
            var squareMetersFoamInPackage = double.Parse(Console.ReadLine());
            var pricePerPackage = double.Parse(Console.ReadLine());
            var areaOfWindows = numberOfWindows * 2.4;
            var clearArea = (areaOfHouse - areaOfWindows) * 1.1;
            var neededPackages = Math.Ceiling(clearArea / squareMetersFoamInPackage);
            var overallPrice = neededPackages * pricePerPackage;

            if (budget>=overallPrice)
            {
                Console.WriteLine($"Spent: {overallPrice:f2}");
                Console.WriteLine($"Left: {budget-overallPrice:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {overallPrice-budget:f2}");
            }
        }
    }
}
