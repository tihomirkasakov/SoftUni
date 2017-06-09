using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = FactorialNumber(number);
            Console.WriteLine(factorial);
        }

        private static BigInteger FactorialNumber(int number)
        {
            BigInteger factorialNumber = 1;
            for (int i = 1; i <= number; i++)
            {
                factorialNumber *= i;
            }
            return factorialNumber;
        }
    }
}
