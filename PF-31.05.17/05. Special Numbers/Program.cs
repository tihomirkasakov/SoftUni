using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int number = 1; number <= a; number++)
            {
                int sum = 0;
                int digit = number;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                bool specialNumber = (sum ==5 || sum ==7 || sum ==11);
                Console.WriteLine($"{number} -> {specialNumber}");
            }
        }
    }
}
