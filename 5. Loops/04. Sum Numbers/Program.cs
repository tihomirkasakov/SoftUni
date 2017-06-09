using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNumbers = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <=numberOfNumbers; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine(sum);
        }
    }
}
