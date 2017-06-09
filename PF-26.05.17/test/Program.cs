using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double spentMoney = 0;
            bool outFall4 = false;
            bool cSOG = false;
            bool zplinterZell = false;
            bool honored2 = false;
            bool rovetWatch = false;
            bool rovetWatchOrigins = false;
            while (true)
            {
                string game = Console.ReadLine();
                if (game == "OutFall 4")
                {
                    outFall4 = true;
                    currentBalance -= 39.99;
                    spentMoney += 39.99;
                    if (currentBalance < 0)
                    {
                        outFall4 = false;
                        Console.WriteLine("Too Expensive");
                        currentBalance += 39.99;
                        spentMoney -= 39.99;
                    }
                }
                else if (game == "CS:OG")
                {
                    cSOG = true;
                    currentBalance -= 15.99;
                    spentMoney += 15.99;
                    if (currentBalance < 0)
                    {
                        cSOG = false;
                        Console.WriteLine("Too Expensive");
                        currentBalance += 15.99;
                        spentMoney -= 15.99;

                    }
                }
                else if (game == "Zplinter Zell")
                {
                    zplinterZell = true;
                    currentBalance -= 19.99;
                    spentMoney += 19.99;
                    if (currentBalance < 0)
                    {
                        zplinterZell = false;
                        Console.WriteLine("Too Expensive");
                        currentBalance += 19.99;
                        spentMoney -= 19.99;
                    }
                }
                else if (game == "RoverWatch")
                {
                    rovetWatch = true;
                    currentBalance -= 29.99;
                    spentMoney += 29.99;
                    if (currentBalance < 0)
                    {
                        rovetWatch = false;
                        Console.WriteLine("Too Expensive");
                        currentBalance += 29.99;
                        spentMoney -= 29.99;
                    }
                }
                else if (game == "Honored 2")
                {
                    honored2 = true;
                    currentBalance -= 59.99;
                    spentMoney += 59.99;
                    if (currentBalance < 0)
                    {
                        honored2 = false;
                        Console.WriteLine("Too Expensive");
                        currentBalance += 59.99;
                        spentMoney -= 59.99;
                    }
                }

                else if (game == "RoverWatch Origins Edition")
                {
                    rovetWatchOrigins = true;
                    currentBalance -= 39.99;
                    spentMoney += 39.99;
                    if (currentBalance < 0)
                    {
                        rovetWatchOrigins = false;
                        Console.WriteLine("Too Expensive");
                        currentBalance += 39.99;
                        spentMoney -= 39.99;
                    }
                }
                else if (game == "Game Time")
                {
                    if (outFall4)
                    {
                        Console.WriteLine("Bought OutFall 4");
                    }
                    if (cSOG)
                    {
                        Console.WriteLine("Bought CS:OG");

                    }
                    if (rovetWatch)
                    {
                        Console.WriteLine("Bought RoverWatch");
                    }
                    if (honored2)
                    {
                        Console.WriteLine("Bought Honored 2");
                    }
                    if (zplinterZell)
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                    }

                    if (rovetWatchOrigins)
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }

                    if (currentBalance > 0)
                    {
                        Console.WriteLine($"Total spent: ${spentMoney}. Remaining: ${currentBalance:F2}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }


                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
    }
}
