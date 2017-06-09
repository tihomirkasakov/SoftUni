using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var palidrome = IsPalidrome(num);
            var validPalidrome = DivBy7(palidrome);

            Console.WriteLine();
            //Console.WriteLine(string.Join("\n",palidrome));
        }

        static List<int> IsPalidrome(int num)
        {
            var digit = 0;
            var palidrome = new List<int>();
            for (int numberToCheck = 1; numberToCheck <= num; numberToCheck++)
            {
                var reverse = 0;
                var number = numberToCheck;
                while (number>0)
                {
                    digit = number % 10;
                    reverse = reverse * 10 + digit;
                    number = number / 10;
                    if (numberToCheck == reverse)
                    {
                        palidrome.Add(numberToCheck);
                    }
                }
            }
            return palidrome;
        }
        static int DivBy7(int palidrome)
        {
            var sum = 0;
            var palidromeToCheck = palidrome;
            if (palidrome/2==0)
            {
                while (palidromeToCheck > 0)
                {
                    sum += palidromeToCheck % 10;
                    palidromeToCheck /= 10;
                }
                if (sum % 7 == 0)
                {
                    return palidrome;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
