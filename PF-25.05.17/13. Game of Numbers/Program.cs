using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var firstNumber = 0;
            var secondNumber = 0;
            var magicFirst = 0;
            var magicSecond = 0;
            var sum = 0;
            var counter = 0;
            for (int i = n; i <= m; i++)
            {
                firstNumber = i;
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    secondNumber = j;
                    sum = firstNumber + secondNumber;
                    if (sum==magicNumber)
                    {
                        magicFirst = firstNumber;
                        magicSecond = secondNumber;
                        continue;
                    }
                }
            }
            if (magicFirst+magicSecond==magicNumber)
            {
                Console.WriteLine($"Number found! {magicFirst} + {magicSecond} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");

            }
        }
    }
}
