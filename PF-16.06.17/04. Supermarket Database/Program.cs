using System;
using System.Collections.Generic;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var database = new Dictionary<string, Dictionary<string, double>>();

            while (name!="stocked")
            {
                var price = double.Parse(input[1]);
                var quantity = int.Parse(input[2]);
                if (!database.ContainsKey(name))
                {
                    database[name] = new Dictionary<string, double>();
                    database[name]["Quantity"] = 0;
                    database[name]["Price"] = 0;
                }
                database[name]["Quantity"] += quantity;
                database[name]["Price"] = price;
                input = Console.ReadLine().Split();
                name = input[0];
            }
            double grandTotal = 0;
            foreach (var item in database)
            {
                var product = item.Key;
                var priceQuantity = item.Value;
                var price = priceQuantity[ "Price"];
                var quantity = priceQuantity["Quantity"];
                grandTotal += price * quantity;
                Console.WriteLine($"{product}: ${price:f2} * {quantity} = ${price*quantity:f2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
