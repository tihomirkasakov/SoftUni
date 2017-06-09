using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            var primesInRange = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primesInRange));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private static bool IsPrime(long number)
        {
            var isPrime = true;
            if (number == 0 || number == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
