using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_25._05._17
{
    class Program
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();
            if (profesion=="Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profesion=="Businessman"||profesion=="Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profesion=="SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
