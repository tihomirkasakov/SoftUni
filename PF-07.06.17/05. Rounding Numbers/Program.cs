using System;
using System.Linq;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            string[] text = input.Split(' ');
            double[] array = text.Select(double.Parse).ToArray();
            double a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                a = Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {a}");
            }
        }
    }
}
