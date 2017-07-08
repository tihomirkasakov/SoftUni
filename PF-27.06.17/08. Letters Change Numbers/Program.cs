using System;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ','\t'},StringSplitOptions.RemoveEmptyEntries);
            double sum = 0.0;
            for (int i = 0; i < input.Length; i++)
            {
                var wordToCheck = input[i].ToCharArray();
                var firstLetter = wordToCheck[0];
                var lastLetter = wordToCheck[wordToCheck.Length-1];
                string stringOfDigits = string.Empty;
                for (int j = 1; j < wordToCheck.Length-1; j++)
                {
                    stringOfDigits = stringOfDigits+wordToCheck[j];
                }
                if (firstLetter.ToString().ToUpper()==firstLetter.ToString())
                {
                    sum += long.Parse(stringOfDigits) / (double)(firstLetter - 64);
                }
                else
                {
                    sum += long.Parse(stringOfDigits) * (double)(firstLetter - 96);
                }
                if (lastLetter.ToString().ToUpper()==lastLetter.ToString())
                {
                    sum -= (lastLetter - 64);
                }
                else
                {
                    sum += (lastLetter - 96);
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
