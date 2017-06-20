using System;
using System.Collections.Generic;
using System.Linq;

namespace PF_13._06._17
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> longestEqual = new List<int>();
            input.Add(int.MaxValue);
            var currentElement = input[0];
            var biggestCount = 1;
            var count = 1;
            longestEqual.Add(input[0]);

            for (int i = 1; i < input.Count; i++)
            {
                if (currentElement==input[i])
                {
                    count++;
                    if (count > biggestCount)
                    {
                        for (int j = biggestCount - 1; j >= 0; j--)
                        {
                            longestEqual.RemoveAt(j);
                        }
                        biggestCount = count;
                        for (int k = 0; k < biggestCount; k++)
                        {
                            longestEqual.Add(input[i]);
                        }
                    }
                }
                else
                {
                    count = 1;
                }
                currentElement = input[i];
            }
            Console.WriteLine(string.Join(" ", longestEqual));
        }
    }
}
