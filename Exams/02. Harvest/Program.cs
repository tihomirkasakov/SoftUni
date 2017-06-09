using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var production = double.Parse(Console.ReadLine());
            var neededLitersVine = double.Parse(Console.ReadLine());
            var numberOfWorkers = double.Parse(Console.ReadLine());
            var overallProduction = area * production;
            var x = overallProduction*0.4;
            var vineMade = x / 2.5;
            if(vineMade>=neededLitersVine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vineMade)} liters.");
                Console.WriteLine($"{Math.Ceiling(vineMade - neededLitersVine)} liters left -> {Math.Ceiling((vineMade - neededLitersVine) / numberOfWorkers)} liters per person.");
                //Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersVine - vineMade)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersVine - vineMade)} liters wine needed.");
                //Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vineMade)} liters.");
                //Console.WriteLine($"{vineMade - neededLitersVine} liters left -> {Math.Ceiling((vineMade - neededLitersVine) / numberOfWorkers)} liters per person.");
            }
        }
    }
}
