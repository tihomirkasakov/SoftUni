using System;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            var reversedNumber = ReverseNumber(number);
            Console.WriteLine(reversedNumber);

        }
        static double ReverseNumber(double number)
        {
            string numberToString = number.ToString();
            string reversedNumber = string.Empty;
            for (int i = numberToString.Length-1; i >=0; i--)
            {
                reversedNumber += numberToString[i];
            }
            double reversedString = double.Parse(reversedNumber);
            return reversedString;
        }
    }
}
