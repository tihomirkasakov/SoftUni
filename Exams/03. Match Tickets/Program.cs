using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            var numberOfPpl = int.Parse(Console.ReadLine());
            var ticketPrice = category == "VIP" ? 499.99 : 249.99;

            var moneyLeft = budget;

            if (numberOfPpl == 1 && numberOfPpl <5)
            {
                moneyLeft = budget * 0.25;
            }
            else if (numberOfPpl >= 5 && numberOfPpl < 10)
            {
                moneyLeft = budget * 0.4;
            }
            else if (numberOfPpl >= 10 && numberOfPpl < 25)
            {
                moneyLeft = budget * 0.5;
            }
            else if (numberOfPpl >= 26 && numberOfPpl < 50)
            {
                moneyLeft = budget * 0.6;
            }
            else
            {
                moneyLeft = budget * 0.75;
            }

            var moneyForTickets = ticketPrice * numberOfPpl;

            if (moneyLeft > moneyForTickets)
            {
                Console.WriteLine($"Yes! You have {(moneyLeft - moneyForTickets):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(moneyForTickets - moneyLeft):f2} leva.");
            }
        }
    }
}
