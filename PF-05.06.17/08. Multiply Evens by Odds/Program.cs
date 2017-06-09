using System;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int oddSum = OddNumber(a);
            int evenSum = EvenNumber(a);
            Console.WriteLine(oddSum*evenSum);
        }

        static int OddNumber(int a)
        {
            int sum = 0;
            a = Math.Abs(a);
            while (a > 0)
            {
                int lastDigit = a % 10;
                if (a % 2 == 1)
                {
                    sum += lastDigit;
                }
                a /= 10;
            }

            return sum;
        }

        static int EvenNumber(int a)
        {
            int sum = 0;
            a = Math.Abs(a);
            while (a>0)
            {
                int lastDigit = a % 10;
                if (a%2==0)
                {
                    sum += lastDigit;
                }
                a /= 10;
            }

            return sum;
        }
    }
}
