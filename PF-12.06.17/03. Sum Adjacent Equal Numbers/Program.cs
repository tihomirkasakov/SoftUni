using System;
using System.Linq;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i]==input[i-1])
                {
                    input[i] += input[i-1];
                    input.RemoveAt(i-1);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
