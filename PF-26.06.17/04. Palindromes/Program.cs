using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();
            foreach (var item in input)
            {
                var isPalindrome = item.ToCharArray();
                Array.Reverse(isPalindrome);
                var stringWord = new string(isPalindrome);
                if (item==stringWord)
                {
                    palindromes.Add(stringWord);
                }
            }
            palindromes = palindromes.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ",palindromes));
        }
    }
}
