using System;
using System.Text.RegularExpressions;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentenceForCentur = Console.ReadLine();
            var pattern = $"{word}";
            var match = Regex.Matches(sentenceForCentur, word);
            var centure = Regex.Replace(sentenceForCentur, pattern, new string('*', word.Length));
            Console.WriteLine(centure);
        }
    }
}
