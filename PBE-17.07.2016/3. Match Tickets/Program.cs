using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            var numberOfPeople = int.Parse(Console.ReadLine());
            var neededMoneyForTickets = 0.0;
            var moneyForTickets = 0.0;
            if (category=="VIP")
            {
                var neededmoneyfortickets = 499.99 * numberOfPeople;
                neededMoneyForTickets = neededmoneyfortickets;
            }
            else if(category=="Normal")
            {
                var neededmoneyfortickets = 249.99 * numberOfPeople;
                neededMoneyForTickets = neededmoneyfortickets;
            }
            if (numberOfPeople>0&&numberOfPeople<5)
            {
                var budgetForTickets = budget * 0.25;
                moneyForTickets = budgetForTickets;
            }
            else if(numberOfPeople>=5&&numberOfPeople<10)
            {
                var budgetForTickets = budget * 0.4;
                moneyForTickets = budgetForTickets;
            }
            else if (numberOfPeople >= 10 && numberOfPeople < 25)
            {
                var budgetForTickets = budget * 0.5;
                moneyForTickets = budgetForTickets;
            }
            else if (numberOfPeople >= 25 && numberOfPeople < 50)
            {
                var budgetForTickets = budget * 0.6;
                moneyForTickets = budgetForTickets;
            }
            else
            {
                var budgetForTickets = budget * 0.75;
                moneyForTickets = budgetForTickets;
            }
            if (moneyForTickets>neededMoneyForTickets)
            {
                Console.WriteLine($"Yes! You have {(moneyForTickets-neededMoneyForTickets):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(neededMoneyForTickets-moneyForTickets):f2} leva.");
            }
        }
    }
}
