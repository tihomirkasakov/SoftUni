using System;

namespace _02.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            long num;
            bool numberToCheck = long.TryParse(number, out num);
            if (numberToCheck)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
