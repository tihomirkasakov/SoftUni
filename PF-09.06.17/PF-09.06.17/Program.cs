using System;
using System.Linq;

namespace PF_09._06._17
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var minValue = array[0];
            var maxValue = array[0];
            double sum = 0;
            double average = 0;

            for (int i = 0; i < array.Length; i++)
            {
                minValue = Math.Min(minValue, array[i]);
                maxValue = Math.Max(maxValue, array[i]);
                sum += array[i];
            }
            average = sum / array.Length;
            Console.WriteLine($"Min = {minValue}");
            Console.WriteLine($"Max = {maxValue}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
