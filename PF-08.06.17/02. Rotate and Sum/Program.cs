using System;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rotations = int.Parse(Console.ReadLine());
            var sumArray = new int[array.Length];

            for (int i = 0; i < rotations; i++)
            {
                    var rotateNumber = array[array.Length - 1];
                    for (int j = array.Length - 1; j > 0; j--)
                    {
                        array[j] = array[j - 1];
                    }
                    array[0] = rotateNumber;
                    for (int k = 0; k < array.Length; k++)
                    {
                    sumArray[k] += array[k];
                    }
            }
            Console.WriteLine(string.Join(" ",sumArray));
        }
    }
}
