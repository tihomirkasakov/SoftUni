using System;
using System.Linq;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] product = Console.ReadLine().Split();
            var quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var priceOfProduct = Console.ReadLine().Split().ToArray();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                for (int i = 0; i < product.Length; i++)
                {
                    if (product[i] == input)
                    {
                        Console.WriteLine($"{product[i]} costs: {priceOfProduct[i]}; Available quantity: {quantity[i]}");
                    }
                }
            }
        }
    }
}
