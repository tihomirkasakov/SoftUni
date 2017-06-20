using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var type = input[0];
                var name = input[1];
                var damage = input[2] != "null" ? decimal.Parse(input[2]) : 45;
                var health = input[3] != "null" ? decimal.Parse(input[3]) : 250;
                var armor = input[4] != "null" ? decimal.Parse(input[4]) : 10;

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }
                dragons[type][name] = new decimal[] { damage, health, armor };
            }
            foreach (var item in dragons)
            {
                var type = item.Key;
                var nameAndStats = item.Value;

                var averageDMG = nameAndStats.Values.Average(x=>x[0]);
                var averageHealth = nameAndStats.Values.Average(x => x[1]);
                var averageArmor = nameAndStats.Values.Average(x => x[2]);

                Console.WriteLine($"{type}::({averageDMG:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var kv in nameAndStats)
                {
                    var name = kv.Key;
                    var dmg = kv.Value[0];
                    var health = kv.Value[1];
                    var armor = kv.Value[2];

                    Console.WriteLine($"-{name} -> damage: {dmg}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}
