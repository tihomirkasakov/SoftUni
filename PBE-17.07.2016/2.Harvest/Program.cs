using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var production = double.Parse(Console.ReadLine());
            var neededLitersWine = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var litersWine = area * production * 0.4 / 2.5;
            if (litersWine<neededLitersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersWine-litersWine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersWine-neededLitersWine)} liters left -> {Math.Ceiling((litersWine-neededLitersWine)/workers)} liters per person.");
            }
        }
    }
}
