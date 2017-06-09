using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0.0;
            var rightSum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                leftSum+= number;
            }
            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                rightSum +=number;
            }
            if(leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}
