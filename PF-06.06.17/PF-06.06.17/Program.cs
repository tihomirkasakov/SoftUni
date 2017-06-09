using System;

namespace PF_06._06._17
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
        }

        static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
