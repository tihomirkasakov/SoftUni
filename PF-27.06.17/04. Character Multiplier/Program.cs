using System;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var firstWord = input[0].ToCharArray();
            var secondWord = input[1].ToCharArray();
            long sum = 0;
            if (firstWord.Length==secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += (int)firstWord[i] * (int)secondWord[i];
                }
            }
            else
            {
                var shorterWord = Math.Min(firstWord.Length, secondWord.Length);
                var longerWord = Math.Max(firstWord.Length, secondWord.Length);
                var word = firstWord.Length>secondWord.Length ? firstWord : secondWord;
                for (int i = 0; i <shorterWord ; i++)
                {
                    sum += (int)firstWord[i] * (int)secondWord[i];
                }
                for (int i = shorterWord; i <longerWord ; i++)
                {
                    sum += word[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
