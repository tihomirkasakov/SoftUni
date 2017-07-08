using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');
            var countofZeros = @"0";
            var countOfOnes = @"1";
            var consZeros = @"0{2,}";
            var consOnes = @"1{2,}";
            var sum = 0;
            var message = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var zeroMatch = Regex.Matches(input[i], consZeros);
                var oneMatch = Regex.Matches(input[i], consOnes);
                foreach (Match item in zeroMatch)
                {
                    sum += item.Length;
                }
                foreach (Match item in oneMatch)
                {
                    sum += item.Length;
                }
                var zeros = Regex.Matches(input[i], countofZeros);
                var ones = Regex.Matches(input[i], countOfOnes);
                sum += (zeros.Count * 3) + (ones.Count * 5);
                message.Append((char)sum);
                sum = 0;
            }
            Console.WriteLine(message);
        }
    }
}
