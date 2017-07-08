using System;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var names = Console.ReadLine();
            var result = Regex.Matches(names, pattern);

            foreach (Match item in result)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
