using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var number = 1;
            var sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum = sum + number;
                Console.WriteLine(number);
                number += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
