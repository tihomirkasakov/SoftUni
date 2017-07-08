using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var pattern = @"\b([a-zA-Z]{5,})@([a-z]{3,}(\.com|\.bg|\.org))\b";
            var output = new Dictionary<string, HashSet<string>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var legitEmail = Regex.Match(input, pattern);
                if (legitEmail.Success)
                {
                    var username = legitEmail.Groups[1].Value;
                    var domain = legitEmail.Groups[2].Value;
                    if (!output.ContainsKey(domain))
                    {
                        output[domain] = new HashSet<string>();
                    }
                    output[domain].Add(username);
                }
            }
            foreach (var item in output.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"### {items}");
                }
            }
        }
    }
}
