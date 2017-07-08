using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToUpper();
            const string InputRegex = @"(\D+)(\d+)";
            var matches = Regex.Matches(inputString, InputRegex);
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                var stringToPrint = match.Groups[1].Value;
                var timesToPrint = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < timesToPrint; i++)
                {
                    result.Append(stringToPrint);
                }
            }
            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}
