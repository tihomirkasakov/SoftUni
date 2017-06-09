﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            for (int i = 0; i < currentHealth; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < maxHealth-currentHealth; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
            Console.Write("Energy: |");
            for (int i = 0; i < currentEnergy; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < maxEnergy-currentEnergy; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
        }
    }
}
