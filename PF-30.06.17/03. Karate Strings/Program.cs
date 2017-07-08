using System;
using System.Text.RegularExpressions;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(?<=>)[0-9]";
            var pattern2 = @"(?<=>)[0-9]\w*";
            int remaining = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var regex = Regex.Match(input, pattern);
                var lenght = Regex.Match(input, pattern2);
                if (!regex.Success)
                {
                    break;
                }
                var strenght = int.Parse(regex.Value)+remaining;
                if (strenght<=lenght.Length)
                {
                    var newString = input.Remove(regex.Index, strenght);
                    input = newString;
                }
                else
                {
                    var newString = input.Remove(regex.Index, lenght.Length);
                    input = newString;
                    remaining = strenght - lenght.Length;
                }
            }
            Console.WriteLine(input);
        }
    }
}
