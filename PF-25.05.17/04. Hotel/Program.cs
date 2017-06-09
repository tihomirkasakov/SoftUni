using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var studio = 0.0;
            var doubleRoom= 0.0;
            var suite = 0.0;
            var nights2 = nights;
            if (month=="May"||month=="October")
            {
                if (nights>7)
                {
                    studio = 50*0.95;
                }
                else
                {
                    studio = 50;
                }
                doubleRoom = 65;
                suite = 75;
            }
            else if (month=="June"||month=="September")
            {
                if (nights > 14)
                {
                    doubleRoom = 72*0.9;
                }
                else
                {
                    doubleRoom = 72;
                }
                studio = 60;
                suite = 82;
            }
            else if (month == "July" || month == "August"||month=="December")
            {
                if (nights > 14)
                {
                    suite = 89*0.85;
                }
                else
                {
                    suite = 89;
                }
                studio = 68;
                doubleRoom = 77;
            }
            if (month=="September"||month=="October")
            {
                if (nights>7)
                {
                    nights2--;
                }
            }
            Console.WriteLine($"Studio: {studio*nights2:f2} lv.");
            Console.WriteLine($"Double: {doubleRoom*nights:f2} lv.");
            Console.WriteLine($"Suite: {suite*nights:f2} lv.");
        }
    }
}
