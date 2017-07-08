using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(0x|\b)[0-9A-F]+\b";
            var hexadecimalNumbers = Console.ReadLine();
            var validNumbers = Regex.Matches(hexadecimalNumbers, regex).Cast<Match>().Select(x=>x.Value).ToArray();
            Console.WriteLine(string.Join(" ",validNumbers));
        }
    }
}
