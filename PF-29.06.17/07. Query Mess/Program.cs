using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"[^&?]+";
            var messless = new Dictionary<string, string>();
            while (input!="END")
            {
                var legit = Regex.Matches(input, pattern);
                foreach (Match item in legit)
                {
                    var field = item.Value.Split('=');
                    var pattern2 = @"((\+|%20)+)";
                    if (field.Length<2)
                    {
                        continue;
                    }
                    var clearKey = Regex.Replace(field[0], pattern2, " ").Trim();
                    var clearValue = Regex.Replace(field[1], pattern2, " ").Trim();
                    if (!messless.ContainsKey(clearKey))
                    {
                        messless[clearKey] = clearValue;
                    }
                    else
                    {
                        messless[clearKey] += ", " + clearValue;
                    }
                }
                foreach (var kvp in messless)
                {
                    Console.Write($"{kvp.Key}=[{kvp.Value}]");
                }
                Console.WriteLine();
                messless.Clear();
                input = Console.ReadLine();
            }
        }
    }
}
