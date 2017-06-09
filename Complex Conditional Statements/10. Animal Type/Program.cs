using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            if(animal=="crocodile"||animal=="tortoise"||animal=="snake")
            {
                Console.WriteLine("reptile");
            }
            else if(animal=="dog")
            {
                Console.WriteLine("mammal");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
