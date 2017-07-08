using System;
using System.Text.RegularExpressions;

namespace _05.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(\d+)([a-zA-Z])";
            var matchDigits = Regex.Matches(input,pattern);
            foreach (Match item in matchDigits)
            {
                var group1 = item.Groups[1].Value;
                var group2 = item.Groups[2].Value;
                input = input.Replace(group1, group2);
            }
            Console.WriteLine(input);
        }
    }
}
