using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split().ToArray();
            var zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var race = new List<NameFuelZone>();

            for (int i = 0; i < drivers.Length; i++)
            {
                var firstLetter=drivers[i].ToCharArray();
                var fuel = firstLetter[0];
                var player = new NameFuelZone { Name = drivers[i], Fuel = fuel, Zone = 0 };
                race.Add(player);

                for (int z = 0; z < zones.Length; z++)
                {
                    if (checkpoints.Contains(z))
                    {
                        player.Fuel += zones[z];
                        player.Zone++;
                    }
                    else
                    {
                        player.Fuel -= zones[z];
                        if (player.Fuel<=0)
                        {
                            break;
                        }
                        player.Zone++;
                    }
                }
            }
            foreach (var item in race)
            {
                var name = item.Name;
                var fuel = item.Fuel;
                if (fuel>0)
                {
                    Console.WriteLine($"{name} - fuel left {fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{name} - reached {item.Zone}");
                }
            }
        }
    }
    class NameFuelZone
    {
        public string Name { get; set; }
        public double Fuel { get; set; }
        public int Zone { get; set; }
    }
}
