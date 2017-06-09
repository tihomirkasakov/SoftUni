using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            if (profesion == "Athlete")
            {
                Console.WriteLine($"The {profesion} has to pay {0.7*quantity:f2}.");
            }
            else if (profesion == "Businessman" || profesion == "Businesswoman")
            {
                Console.WriteLine($"The {profesion} has to pay {1.0 * quantity:f2}.");
            }
            else if (profesion == "SoftUni Student")
            {
                Console.WriteLine($"The {profesion} has to pay {1.7 * quantity:f2}.");
            }
            else
            {
                Console.WriteLine($"The {profesion} has to pay {1.2 * quantity:f2}.");
            }
        }
    }
}
