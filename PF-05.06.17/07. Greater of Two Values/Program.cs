using System;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    int maxNumber = GetMax(firstNumber, secondNumber);
                    Console.WriteLine(maxNumber);
                    break;

                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char maxChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(maxChar);
                    break;

                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string maxString = GetMax(firstString, secondString);
                    Console.WriteLine(maxString);
                    break;
            }
        }
        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber>=secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar>=secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString)>=0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
