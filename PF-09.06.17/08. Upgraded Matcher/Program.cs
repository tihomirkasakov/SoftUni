using System;
using System.Linq;

namespace _08.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] product = Console.ReadLine().Split();
            long []quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var priceOfProduct = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Array.Resize(ref quantity, product.Length);
            while (true)
            {
                var input = Console.ReadLine().Split();
                var productName = input[0];
                if (productName == "done")
                {
                    break;
                }
                for (int i = 0; i < product.Length; i++)
                {
                    if (product[i] == productName)
                    {
                        if (long.Parse(input[1])>quantity[i])
                        {
                            Console.WriteLine($"We do not have enough {product[i]}");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"{productName} x {input[1]} costs {long.Parse(input[1]) * priceOfProduct[i]:f2}");
                            quantity[i] -= long.Parse(input[1]);
                        }
                    }
                }
            }
        }
    }
}
