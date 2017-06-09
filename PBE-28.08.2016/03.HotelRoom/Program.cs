using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            var numberOfNights = int.Parse(Console.ReadLine());
            var studio = 0.0;
            var apartment = 0.0;
            if (month=="May"||month=="October")
            {
                studio = 50 * numberOfNights;
                apartment = 65 * numberOfNights;
                if (numberOfNights > 7&&numberOfNights<=14)
                {
                    studio = studio * 0.95;
                }
                else if (numberOfNights>14)
                {
                    studio = studio * 0.7;
                }
            }
            else if (month=="June"||month=="September")
            {
                studio = 75.20*numberOfNights;
                apartment = 68.70 * numberOfNights;
                if (numberOfNights>14)
                {
                    studio = studio * 0.8;
                }
            }
            else if (month=="July"||month=="August")
            {
                studio = 76 * numberOfNights;
                apartment = 77 * numberOfNights;
            }
            if (numberOfNights>14)
            {
                Console.WriteLine($"Apartment: {(apartment*0.9):f2} lv.");
            }
            else
            {
                Console.WriteLine($"Apartment: {apartment:f2} lv.");
            }
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
