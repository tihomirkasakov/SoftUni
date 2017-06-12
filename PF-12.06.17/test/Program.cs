using System;
using System.Linq;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort();
            var count = 1;
            var currentNumber = input[0];
            input.Add(int.MaxValue);
            for (int i = 1; i < input.Count; i++)
            {
                if (currentNumber==input[i])
                {
                    count++;
                }
                else
                {
                    if (count>=1)
                    {
                        Console.WriteLine($"{input[i-1]} -> {count}");
                    }

                    count = 1;
                }
                currentNumber = input[i];
            }
        }
    }
}
