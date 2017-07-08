using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var numberSystem = BigInteger.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);
            var convertedNumbers = string.Empty;
            
            while(number!=0)
            {
                var dividedDiff = number % numberSystem;
                convertedNumbers = dividedDiff+convertedNumbers;
                number = number - dividedDiff;
                number = number / numberSystem;
            }
            Console.WriteLine(string.Join("",convertedNumbers));
        }
    }
}
