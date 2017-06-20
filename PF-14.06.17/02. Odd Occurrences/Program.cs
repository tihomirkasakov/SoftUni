using System;
using System.Collections.Generic;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split();
            var oddStrings = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!oddStrings.ContainsKey(item))
                {
                    oddStrings[item] = 0;
                }
                oddStrings[item]++;
            }
            var result = new List<string>();
            foreach (var item in oddStrings)
            {
                if (item.Value%2==1)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
