using System;
using System.Linq;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lastNumber = int.Parse(Console.ReadLine());
            double sum = 0.0;
            int count = 0;

            for (int i = array.Length-1; i >= 0; i--)
            {
                if (array[i]==lastNumber)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sum += array[j];
                    }
                    count++;
                    break;
                }
            }
            Console.WriteLine((count == 0) ? "No occurrences were found!" : $"{sum}");
        }
    }
}
