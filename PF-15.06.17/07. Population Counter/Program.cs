using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');
            var countryCityPopulation = new Dictionary<string, Dictionary<string, decimal>>();

            while (input[0]!="report")
            {
                var country = input[1];
                var city = input[0];
                var population = decimal.Parse(input[2]);

                if (!countryCityPopulation.ContainsKey(country))
                {
                    countryCityPopulation[country] = new Dictionary<string, decimal>();
                }

                if (!countryCityPopulation[country].ContainsKey(city))
                {
                    countryCityPopulation[country][city] = population;
                }
                else
                {
                    countryCityPopulation[country][city] += population;
                }

                input = Console.ReadLine().Split('|');
            }
            foreach (var item in countryCityPopulation.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                var country = item.Key;
                var cityPopulation = item.Value;
                var population = cityPopulation.Values.Sum(x=>x);

                Console.WriteLine($"{country} (total population: {population})");
                foreach (var kv in cityPopulation.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{kv.Key}: {kv.Value}");
                }
            }
        }
    }
}
