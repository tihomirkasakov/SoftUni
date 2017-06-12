using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> sqrt = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i])==(int)Math.Sqrt(input[i]))
                {
                    sqrt.Add(input[i]);
                }
            }

            sqrt.Sort();
            sqrt.Reverse();

            Console.WriteLine(string.Join(" ",sqrt));
        }
    }
}
