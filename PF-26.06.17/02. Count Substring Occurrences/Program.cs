using System;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();
            var count = 0;
            var output = input.IndexOf(substring);
            while (output!=-1)
            {
                count++;
                output = input.IndexOf(substring, output + 1);
            }
            Console.WriteLine(count);
        }
    }
}
