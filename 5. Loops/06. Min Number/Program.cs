using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var min = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < min)
                    min = number;
            }
            Console.WriteLine(min);
        }
    }
}
