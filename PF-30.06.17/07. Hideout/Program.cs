using System;
using System.Text.RegularExpressions;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = Console.ReadLine();
            while (true)
            {
                var countOfChar = Console.ReadLine().Split();
                var charToSearch = countOfChar[0];
                int counts = int.Parse(countOfChar[1]);
                var pattern = $@"\{charToSearch}{{{counts},}}";
                var index = Regex.Match(map, pattern);
                if (index.Success)
                {
                    Console.WriteLine($"Hideout found at index {index.Index} and it is with size {index.Length}!");
                    break;
                }
            }
        }
    }
}
