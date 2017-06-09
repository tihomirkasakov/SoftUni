using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06___Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var firstNumber = a;
            var secondNumber = a;
            var sum = 0;
            var countt1 = 0;

            for (int j = a; j <= b; j++)
            {
                secondNumber = a;
                if (secondNumber < b)
                {
                    for (int i = a; i <= b; i++)
                    {
                        secondNumber = i;
                        countt1 += 1;
                        sum = firstNumber + secondNumber;
                        if (sum == c)
                        {
                            Console.WriteLine($"Combination N:{countt1} ({firstNumber} + {secondNumber} = {c})");
                            break;
                        }
                    }
                }
                firstNumber += 1;
                if (sum == c)
                {
                    break;
                }
            }
            if (sum!=c)
            {
                Console.WriteLine($"{countt1} combinations - neither equals {c}");
            }
        }
    }
}
