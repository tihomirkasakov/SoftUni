using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());
            var cost = 0.0;
            for (int i = 1; i <=numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                var price = double.Parse(Console.ReadLine());
                var itemQuantity = int.Parse(Console.ReadLine());
                if (itemQuantity>1)
                {
                    Console.WriteLine($"Adding {itemQuantity} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemQuantity} {itemName} to cart.");
                }
                cost += price*itemQuantity;
            }
            Console.WriteLine($"Subtotal: ${cost:f2}");
            if (budget >= cost)
            {
                Console.WriteLine($"Money left: ${budget - cost:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${cost - budget:f2} more.");
            }
        }
    }
}
