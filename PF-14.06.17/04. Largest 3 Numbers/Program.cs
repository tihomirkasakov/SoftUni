using System;
using System.Linq;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result=input.OrderByDescending(i => i).Take(3);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
