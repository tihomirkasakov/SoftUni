using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classOfCar = "";
            string car = "";
            var price =0.0;
            if (budget<=100)
            {
                classOfCar = "Economy class";
                if (season=="Summer")
                {
                    car = "Cabrio";
                    price = budget * 0.35;
                }
                else
                {
                    car = "Jeep";
                    price = budget * 0.65;
                }
            }
            else if (budget>100&&budget<=500)
            {
                classOfCar = "Compact class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    car = "Jeep";
                    price = budget * 0.8;
                }
            }
            else
            {
                classOfCar = "Luxury class";
                car = "Jeep";
                price = budget * 0.9;
            }
            Console.WriteLine($"{classOfCar}");
            Console.WriteLine($"{car} - {price:f2}");
        }
    }
}
