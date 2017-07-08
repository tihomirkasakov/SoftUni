using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var nameHealthDmg = new Dictionary<string, Dictionary<double, double>>();
            for (int i = 0; i < input.Length; i++)
            {
                var name = input[i];
                double health = 0;
                double damage = 0;

                if (!nameHealthDmg.ContainsKey(name))
                {
                    nameHealthDmg[name] = new Dictionary<double, double>();
                }

                var healthPattern = @"[^0-9+\-*\/\.]";
                var letters = Regex.Matches(name, healthPattern);
                foreach (Match values in letters)
                {
                    var letter = char.Parse(values.Value);
                    health = letter + health;
                }

                var damagePattern = @"(-|\+)?[0-9.]+";
                var digits = Regex.Matches(name, damagePattern);
                foreach (Match values in digits)
                {
                    var digit = double.Parse(values.Value);
                    damage += digit;
                }

                var multiplierPattern = @"\*|\/";
                var multiply = Regex.Matches(name, multiplierPattern);
                foreach (Match item in multiply)
                {
                    var sign = char.Parse(item.Value);
                    if (sign == '*')
                    {
                        damage = damage * 2;
                    }
                    else
                    {
                        damage = damage / 2;
                    }
                }
                nameHealthDmg[name][health] = damage;
            }
            foreach (var item in nameHealthDmg.OrderBy(n => n.Key))
            {
                var dragonName = item.Key;
                var dragonHealthDamage = item.Value;
                foreach (var kvp in dragonHealthDamage)
                {
                    var dragonHealth = kvp.Key;
                    var dragonDamage = kvp.Value;
                    Console.WriteLine($"{dragonName} - {dragonHealth} health, {dragonDamage:f2} damage");
                }
            }
        }
    }
}
