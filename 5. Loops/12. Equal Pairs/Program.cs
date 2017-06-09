using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var firstSum = 0;
            var secondSum = 0;
            var diff = 0;
            var maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                secondSum = firstSum;
                firstSum = 0;
                firstSum += int.Parse(Console.ReadLine());
                firstSum+= int.Parse(Console.ReadLine());
                if (i!=0)
                diff =Math.Abs(firstSum-secondSum);
                if (diff != 0&&diff>maxDiff)
                    maxDiff = diff;
            }
            if (firstSum==secondSum||n==1)
            {
                Console.WriteLine($"Yes, value={firstSum}");
            }
            else
            {
                Console.WriteLine($"No, maxDiff={maxDiff}");
            }
            
        }
    }
}
