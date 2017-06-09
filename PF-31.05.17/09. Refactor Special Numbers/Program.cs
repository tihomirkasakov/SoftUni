using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 1; number <= n; number++)
            {
                int sum = 0;
                int num=number ;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                bool specialNumber = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine($"{number} -> {specialNumber}");
            }
        }
    }
}
