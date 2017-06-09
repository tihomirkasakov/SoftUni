using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (a>=b)
            {
                Console.WriteLine($"Greater number is {a}");
            }
            else
                Console.WriteLine($"Greater number is {b}");
        }
    }
}
