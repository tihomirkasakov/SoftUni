using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var balance = double.Parse(Console.ReadLine());
            var game = "";
            var spend = 0.0;
            while (game!="Game Time")
            {
                game = Console.ReadLine();
                if (game == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${balance:f2}");
                    break;
                }
                switch (game)
                {

                    case "OutFall 4":balance -= 39.99; spend += 39.99;
                        if (balance<0)
                        {
                            balance += 39.99;spend -= 39.99;
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        if (balance==0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "CS: OG":balance -= 15.99; spend += 15.99;
                        if (balance < 0)
                        {
                            balance += 15.99; spend -= 15.99;
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "Zplinter Zell":balance -= 19.99; spend += 19.99;
                        if (balance < 0)
                        {
                            balance += 19.99; spend -= 19.99;
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "Honored 2":balance -= 59.99;spend += 59.99;
                        if (balance < 0)
                        {
                            balance += 59.99; spend -= 59.99;
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "RoverWatch":balance -= 29.99;spend += 29.99;
                        if (balance < 0)
                        {
                            balance += 29.99; spend -= 29.99;
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    case "RoverWatch Origins Edition":balance -= 39.99;spend += 39.99;
                        if (balance < 0)
                        {
                            balance += 39.99; spend -= 39.99;
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {game}");
                        if (balance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }
        }
    }
}
