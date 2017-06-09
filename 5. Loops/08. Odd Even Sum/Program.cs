using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var evenSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                    oddSum += number;
                else
                    evenSum += number;
            }
                if (oddSum == evenSum)
                {
                    Console.WriteLine($"Yes Sum = {oddSum}");
                }
                else
                {
                    Console.WriteLine($"No Diff = {Math.Abs(oddSum-evenSum)}");
                }
            
        }
    }
}
