using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?[0-9]+(.\d+)?($|(?=\s))";
            var digits = Console.ReadLine();
            var validDigits = Regex.Matches(digits, regex).Cast<Match>().Select(x=>x.Value).ToArray();

            Console.WriteLine(string.Join(" ",validDigits));
        }
    }
}
