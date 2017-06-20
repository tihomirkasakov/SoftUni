using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            List<string> input = new List<string>();
            var list = new Dictionary<string, long>();
            while (!input.Contains("stop"))
            {
                input.Add(Console.ReadLine());
            }
            for (int i = 1; i < input.Count; i += 2)
            {
                if (!list.ContainsKey(input[i-1]))
                {
                    list[input[i - 1]] = long.Parse(input[i]);
                }
                else
                {
                    list[input[i - 1]] += long.Parse(input[i]);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
