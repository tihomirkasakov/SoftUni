using System;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            var lastNumber = LastNumber(number);
            var word = LastWord(lastNumber);
            Console.WriteLine(word);
        }

        static int LastNumber(long number)
        {
            var lastNumber = number % 10;
            return Math.Abs((int)lastNumber);
        }
        static string LastWord(int lastNumber)
        {
            string word = string.Empty;
            switch (lastNumber)
            {
                case 1:
                    word = "one";
                    return word;
                case 2:
                    word = "two";
                    return word;
                case 3:
                    word = "three";
                    return word;
                case 4:
                    word = "four";
                    return word;
                case 5:
                    word = "five";
                    return word;
                case 6:
                    word = "six";
                    return word;
                case 7:
                    word = "seven";
                    return word;
                case 8:
                    word = "eight";
                    return word;
                case 9:
                    word = "nine";
                    return word;
                default:
                    word = "zero";
                    return word;
            }

        }
    }
}
