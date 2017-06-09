using System;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxValue = GetMax(a, b, c);
            Console.WriteLine(maxValue);
        }

        private static int GetMax(int a, int b, int c)
        {
            if (a>b&&a>c)
            {
                return a;
            }
            else if(b>a&&b>c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
