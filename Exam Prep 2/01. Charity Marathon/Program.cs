using System;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfrunners = int.Parse(Console.ReadLine());
            double avgLapsOfRunner = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            int maxRunners = days * capacity;
            if (maxRunners<numberOfrunners)
            {
                numberOfrunners = maxRunners;
            }
            double totalKilometers = (numberOfrunners * avgLapsOfRunner * length)/1000;
            double moneyRaised = totalKilometers * moneyPerKilometer;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
