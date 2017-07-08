using System;
using System.Text.RegularExpressions;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"<a.*?href.*?=(.*)>(.*)</a>";
            var input = Console.ReadLine();
            var replacement = @"[URL href=$1]$2[/URL]";
            while (input!="end")
            {
                var editedText = Regex.Replace(input, regex, replacement);
                Console.WriteLine(editedText);
                input = Console.ReadLine();
            }
        }
    }
}
