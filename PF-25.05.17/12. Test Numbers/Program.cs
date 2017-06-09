using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
            var multiply = 0;
            var sum = 0;
            var counter = 0;
            for (int i = n; i >=1; i--)
            {
                for (int j = 1; j <=m; j++)
                {
                    multiply = i * j * 3;
                    sum += multiply;
                    counter++;
                    if (sum>=controlNumber)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
