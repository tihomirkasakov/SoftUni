using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            var moves = 0;

            for (int firstNumber = 1; firstNumber <= a; firstNumber++)
            {
                var sumFirstNumber = 0;
                sumFirstNumber += firstNumber * 2;
                for (int secondNumber = b; secondNumber >= 1; secondNumber--)
                {
                    moves += 1;
                    var sumSecondNumber = 0;
                    sumSecondNumber += secondNumber * 3;
                    sum += sumFirstNumber + sumSecondNumber;
                    if (sum>=controlNumber)
                    {
                        Console.WriteLine($"{moves} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{moves} moves");
        }
    }
}
