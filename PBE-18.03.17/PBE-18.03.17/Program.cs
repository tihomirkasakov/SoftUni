using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBE_18._03._17
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = a / 2;
            var sides = (a * c) * 2;
            var back = (c * c) + (c * (b - c)) / 2;
            var front = (c * c) + (c * (b - c)) / 2 - (a / 5) * (a / 5);
            var roof = 2 * (a * c);
            Console.WriteLine($"{ (sides + back + front) / 3:f2}");
            Console.WriteLine($"{roof/5:f2}");
        }
    }
}
