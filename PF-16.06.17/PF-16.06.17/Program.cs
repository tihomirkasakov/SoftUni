using System;
using System.Collections.Generic;
using System.Linq;

namespace PF_16._06._17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            input.Sort();
            Console.WriteLine(string.Join(", ",input));
        }
    }
}
