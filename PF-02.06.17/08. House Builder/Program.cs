using System;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());

            if (a>=sbyte.MinValue&&a<=sbyte.MaxValue)
            {
                long sum = a * 4 + b * 10;
                Console.WriteLine(sum);
            }
            else
            {
                long sum = a * 10 + b * 4;
                Console.WriteLine(sum);
            }
        }
    }
}
