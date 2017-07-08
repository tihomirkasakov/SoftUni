using System;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var numberSystem = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);
            var power = 0;
            var result = new BigInteger(0);

            while (number!=0)
            {
                var dividedDiff = number % 10;
                var numberOnPower = BigInteger.Pow(numberSystem, power);
                result += dividedDiff * numberOnPower;
                power++;
                number /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
