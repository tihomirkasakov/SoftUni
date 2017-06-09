using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] item = input.Split(' ');
            double[] array = item.Select(double.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                double a = array[i];
                for (int j = 1; j < array.Length; j++)
                {
                    double b = array[j];
                    if (array.Contains(a + b) && i < j)
                    {
                        count++;
                        Console.WriteLine($"{array[i]} + {array[j]} == {a + b}");
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
