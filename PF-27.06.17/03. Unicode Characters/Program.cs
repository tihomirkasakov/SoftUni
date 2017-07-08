using System;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            foreach (var item in input)
            {
                Console.Write($"\\u{(int)item:x4}");
            }
            Console.WriteLine();
        }
    }
}
