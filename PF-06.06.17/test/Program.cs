using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
                var digit = 0;
            var palidrome = 0;
            for (int numberToCheck = 1; numberToCheck <= num; numberToCheck++)
            {
                var reverse = 0;
                var number = numberToCheck;
                while (number > 0)
                {
                    digit = number % 10;
                    reverse = reverse * 10 + digit;
                    number = number / 10;
                    if (numberToCheck == reverse)
                    {
                        palidrome = numberToCheck;
                    }
                    }

                var sum = 0;
                var palidromeToCheck = palidrome;
                while (palidromeToCheck > 0)
                {
                    sum += palidromeToCheck % 10;
                    palidromeToCheck /= 10;
                }
                if (sum % 7 == 0)
                {
                    Console.WriteLine(palidrome);
                }
            }
        }
    }
}
