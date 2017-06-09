using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Math.Abs(int.Parse(Console.ReadLine()));
            while (true)
            {
                if (a % 2 == 1)
                    break;
                Console.WriteLine("Please write an odd number.");
                a = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number is: {a}");
        }
    }
}
