using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            items["shards"] = 0;
            items["fragments"] = 0;
            items["motes"] = 0;
            bool farmMore = true;
            while (farmMore)
            {
                var input = Console.ReadLine().Split();
                for (int length = 1; length < input.Length; length++)
                {
                    if (length%2==1)
                    {
                        var item = input[length].ToLower();
                        var quantity = int.Parse(input[length - 1]);
                        if (!items.ContainsKey(item))
                        {
                            items[item] = quantity;
                        }
                        else
                        {
                            items[item] += quantity;
                        }
                    }

                    foreach (var kv in items)
                    {
                        switch (kv.Key)
                        {
                            case "shards":
                                if (kv.Value >= 250)
                                {
                                    Console.WriteLine("Shadowmourne obtained!");
                                    items["shards"] -= 250;
                                    foreach (var item in items.Take(3).OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }
                                    foreach (var item in items.Skip(3).OrderBy(x => x.Key))
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }

                                    return;
                                }
                                break;
                            case "fragments":
                                if (kv.Value>=250)
                                {
                                    Console.WriteLine("Valanyr obtained!");
                                    items["fragments"] -= 250;
                                    foreach (var item in items.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }
                                    foreach (var item in items.Skip(3).OrderBy(x => x.Key))
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }

                                    return;
                                }
                                break;
                            case "motes":
                                if (kv.Value>=250)
                                {
                                    Console.WriteLine("Dragonwrath obtained!");
                                    items["motes"] -= 250;
                                    foreach (var item in items.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }
                                    foreach (var item in items.Skip(3).OrderBy(x => x.Key))
                                    {
                                        Console.WriteLine($"{item.Key}: {item.Value}");
                                    }

                                    return;
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}
