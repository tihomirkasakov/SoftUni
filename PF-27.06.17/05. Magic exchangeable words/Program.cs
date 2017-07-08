using System;
using System.Collections.Generic;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            string firstString = input[0];
            string secondString = input[1];
            int shorter = Math.Min(firstString.Length, secondString.Length);
            var shorterWord = firstString.Length > secondString.Length ? secondString : firstString;
            var longerWord = firstString.Length > secondString.Length ? firstString : secondString;
            Dictionary<char, char> magicChars = new Dictionary<char, char>();

            for (int i = 0; i < shorter; i++)
            {
                if (!magicChars.ContainsKey(longerWord[i]))
                {
                    magicChars[longerWord[i]] = shorterWord[i];
                }
                else if(magicChars[longerWord[i]]!=shorterWord[i])
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            var len = longerWord.Substring(shorter);
            for (int i = 0; i < len.Length; i++)
            {
                char currentChar = len[i];

                if (!magicChars.ContainsKey(len[i]))
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
        }
    }
}
