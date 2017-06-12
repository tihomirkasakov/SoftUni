using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = array.Length / 4;
            var leftArray = new int[k];
            var rightArray = new int[k];
            var sumArray = new int[2*k];

            for (int i = 0; i < k; i++)
            {
                leftArray[i] = array[i];
                rightArray[i] = array[3 *k+i];
            }
            Array.Reverse(leftArray);
            Array.Reverse(rightArray);
            for (int i = 0; i < 2*k; i++)
            {
                sumArray[i] = array[k+ i];
            }
            for (int i = 0; i < k; i++)
            {
                sumArray[i] += leftArray[i];
                sumArray[k + i] += rightArray[i];
            }
            Console.WriteLine(string.Join(" ",sumArray));
        }
    }
}
