using System;
using System.Collections.Generic;
using System.Linq;

namespace PF_14._06._17
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse);
            var sortedNumbers = new SortedDictionary<double, int>();
            foreach (var number in input)
            {
                if (!sortedNumbers.ContainsKey(number))
                {
                    sortedNumbers[number] = 0;
                }
                sortedNumbers[number]++;
            }   
            foreach (var item in sortedNumbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
