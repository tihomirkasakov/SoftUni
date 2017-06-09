using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            for (int number = 2; number <= maxNumber; number++)
            {
                bool isTrue = true;
                for (int delio = 2; delio <= Math.Sqrt(number); delio++)
                {
                    if (number % delio == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isTrue}");
            }
        }
    }
}
