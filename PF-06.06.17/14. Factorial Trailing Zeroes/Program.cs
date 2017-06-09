using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = FactorialNumber(number);
            int traillingZeros = TrailingZeros(factorial);
            Console.WriteLine(traillingZeros);
        }

        private static int TrailingZeros(BigInteger factorial)
        {
            int count = 0;
            while (factorial%10==0)
            {
                    count++;
                    factorial /= 10;
            }
            return count;
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
