using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (b<10)
            {
                for (int i = b; i <= 10; i++)
                {
                    Console.WriteLine($"{a} X {i} = {a * i}");
                }
            }
            else
            {
                Console.WriteLine($"{a} X {b} = {a * b}");
            }
        }
    }
}
