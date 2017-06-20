using System;
using System.Linq;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                var temp = input[i];
                char[] reverseString = temp.ToCharArray();
                Array.Reverse(reverseString);
                string reverseToNumbers = new string (reverseString);
                sum += int.Parse(reverseToNumbers);
            }
            Console.WriteLine(sum);
        }
    }
}
