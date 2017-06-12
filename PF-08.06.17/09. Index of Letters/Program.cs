using System;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} -> {(int)array[i]-97}");
            }
        }
    }
}
