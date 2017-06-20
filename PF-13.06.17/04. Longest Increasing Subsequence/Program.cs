using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] length = new int[input.Length];
            int[] currentLenght = new int[input.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < input.Length; i++)
            {
                length[i] = 1;
                currentLenght[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        currentLenght[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }
            var longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(input[lastIndex]);
                lastIndex = currentLenght[lastIndex];
            }

            longestSeq.Reverse();
            Console.WriteLine(string.Join(" ",longestSeq));
        }
    }
}
