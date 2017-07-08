using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            var numbers = Console.ReadLine();
            var validNumbers = Regex.Matches(numbers, regex).Cast<Match>().Select(x=>x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",validNumbers));
        }
    }
}
