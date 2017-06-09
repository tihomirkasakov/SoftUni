using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            var kmPerMonth = double.Parse(Console.ReadLine());
            var salery = 0.0;

            if (kmPerMonth<=5000)
            {
                if (season=="Spring"||season=="Autumn")
                {
                    salery = kmPerMonth * 0.75;
                }
                else if (season=="Summer")
                {
                    salery = kmPerMonth * 0.9;
                }
                else if (season=="Winter")
                {
                    salery = kmPerMonth * 1.05;
                }
            }
            else if (kmPerMonth>5000&&kmPerMonth<=10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salery = kmPerMonth * 0.95;
                }
                else if (season == "Summer")
                {
                    salery = kmPerMonth * 1.1;
                }
                else if (season == "Winter")
                {
                    salery = kmPerMonth * 1.25;
                }

            }
            else if (kmPerMonth>10000&&kmPerMonth<=20000)
            {
                salery = kmPerMonth * 1.45;
            }
            Console.WriteLine($"{salery*0.9*4:f2}");
        }
    }
}
