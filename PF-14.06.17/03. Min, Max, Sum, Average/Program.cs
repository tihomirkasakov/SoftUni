using System;
using System.Linq;

namespace _03.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            double [] array = new double[number];
            for (int i = 0; i < number; i++)
            {
                var input = double.Parse(Console.ReadLine());
                array[i] = input;
            }
            Console.WriteLine($"Sum = {array.Sum()}");
            Console.WriteLine($"Min = {array.Min()}");
            Console.WriteLine($"Max = {array.Max()}");
            Console.WriteLine($"Average = {array.Average()}");
        }
    }
}
