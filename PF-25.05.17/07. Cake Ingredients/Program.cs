using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                var count = i;
                string ingredient = Console.ReadLine();
                if (ingredient=="Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
            }
        }
    }
}
