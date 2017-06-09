using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());
            Console.WriteLine($"{volume}ml {product}:");
            Console.WriteLine($"{volume*energy/100}kcal, {volume*sugar/100}g sugars");
        }
    }
}
