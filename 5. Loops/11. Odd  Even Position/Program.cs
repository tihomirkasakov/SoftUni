using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var oddSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            var evenSum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddSum += number;
                    if (number < oddMin)
                        oddMin = number;
                    if (number > oddMax)
                        oddMax = number;
                }
                else if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number < evenMin)
                        evenMin = number;
                    if (number > evenMax)
                        evenMax = number;
                }
            }
            Console.WriteLine($"OddSum={oddSum}");
            if (oddSum == 0)
            {
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMax=No");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin}");
                Console.WriteLine($"OddMax={oddMax}");
            }
            Console.WriteLine($"EvenSum={evenSum}");
            if (evenSum == 0)
            {
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin}");
                Console.WriteLine($"EvenMax={evenMax}");
            }
        }
    }
}
