using System;
using System.Text.RegularExpressions;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(\d{2})(.|/|-)([A-Z][a-z]{2})\2(\d{4})\b";
            var dates = Console.ReadLine();
            var validDates = Regex.Matches(dates, regex);
            foreach (Match item in validDates)
            {
                var day = item.Groups[1].Value;
                var month = item.Groups[3].Value;
                var year = item.Groups[4].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
