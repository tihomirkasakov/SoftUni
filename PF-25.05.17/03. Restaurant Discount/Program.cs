using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            var price = 0.0;
            if (group<=50)
            {
                Console.WriteLine($"We can offer you the Small Hall");
                price = price + 2500;
                if (package=="Normal")
                {
                    price = price + 500;
                    Console.WriteLine($"The price per person is {price * 0.95 / group:f2}$");
                }
                else if (package == "Gold")
                {
                    price = price + 750;
                    Console.WriteLine($"The price per person is {price * 0.9 / group:f2}$");
                }
                else if (package == "Platinum")
                {
                    price = price + 1000;
                    Console.WriteLine($"The price per person is {price * 0.85 / group:f2}$");
                }
            }
            else if (group>50&&group<=100)
            {
                Console.WriteLine($"We can offer you the Terrace");
                price = price + 5000;
                if (package == "Normal")
                {
                    price = price + 500;
                    Console.WriteLine($"The price per person is {price * 0.95 / group:f2}$");
                }
                else if (package == "Gold")
                {
                    price = price + 750;
                    Console.WriteLine($"The price per person is {price * 0.9 / group:f2}$");
                }
                else if (package == "Platinum")
                {
                    price = price + 1000;
                    Console.WriteLine($"The price per person is {price * 0.85 / group:f2}$");
                }
            }
            else if (group>100&&group<=120)
            {
                Console.WriteLine($"We can offer you the Great Hall");
                price = price + 7500;
                if (package == "Normal")
                {
                    price = price + 500;
                    Console.WriteLine($"The price per person is {price * 0.95 / group:f2}$");
                }
                else if (package == "Gold")
                {
                    price = price + 750;
                    Console.WriteLine($"The price per person is {price * 0.9 / group:f2}$");
                }
                else if (package == "Platinum")
                {
                    price = price + 1000;
                    Console.WriteLine($"The price per person is {price * 0.85 / group:f2}$");
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
