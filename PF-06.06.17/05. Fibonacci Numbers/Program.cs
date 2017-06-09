using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long fibonacciNumber = FibonacciLoop(number);
            Console.WriteLine(fibonacciNumber);
        }

        private static long FibonacciLoop(int number)
        {
            long firstNumber = 0;
            long secondNumber = 1;
            long fibonacciNumber = 0;
            if (number==0)
            {
                fibonacciNumber = 1;
                return fibonacciNumber;
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    fibonacciNumber = firstNumber + secondNumber;
                    if (i % 2 == 1)
                    {
                        firstNumber = fibonacciNumber;
                    }
                    else
                    {
                        secondNumber = fibonacciNumber;
                    }
                }
                return fibonacciNumber;
            }
        }
    }
}
