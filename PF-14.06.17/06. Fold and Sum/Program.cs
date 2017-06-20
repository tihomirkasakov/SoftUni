using System;
using System.Linq;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = input.Length / 4;
            var leftPart = input.Take(k).Reverse().ToArray();
            var rightPart = input.Reverse().Take(k).ToArray();
            var sumPartOne = leftPart.Concat(rightPart).ToArray();
            var sumPartTwo = input.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < sumPartOne.Length; i++)
            {
                sumPartOne[i] += sumPartTwo[i];
            }
            Console.WriteLine(string.Join(" ",sumPartOne));
        }
    }
}
