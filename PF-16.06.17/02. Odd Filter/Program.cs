using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]%2==0)
                {
                    evenNumbers.Add(input[i]);
                }
            }
            var average = evenNumbers.Average();
            for (int i = 0; i < evenNumbers.Count; i++)
            {
                if (evenNumbers[i]>average)
                {
                    evenNumbers[i]++;
                }
                else
                {
                    evenNumbers[i]--;
                }
            }
            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}
