﻿using System;

namespace _09.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string word="";
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
