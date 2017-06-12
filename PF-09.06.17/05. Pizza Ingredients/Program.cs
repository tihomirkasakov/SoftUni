using System;
using System.Linq;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine().Split().ToArray();
            int length = int.Parse(Console.ReadLine());
            var count = 0;
            string[] usedIngredients = new string[10];

            for (int i = 0; i < ingredient.Length; i++)
            {
                int charLength = ingredient[i].Length;
                if (charLength==length)
                {
                    Console.WriteLine($"Adding {ingredient[i]}.");
                    usedIngredients[count] = ingredient[i];
                    count++;
                }
                if (count==10)
                {
                    break;
                }
            }
            Array.Resize(ref usedIngredients, count);
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",usedIngredients)}.");
        }
    }
}
