using System;

class Program
{
    static void Main()
    {
        decimal bananaCount = 2;
        decimal eggsCount = 4;
        decimal berriesWeight = 0.2m;

        decimal moneyAvailable = decimal.Parse(Console.ReadLine());
        long guests = long.Parse(Console.ReadLine());
        decimal bananaPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPrice = decimal.Parse(Console.ReadLine());

        var dessertCount = Math.Ceiling(guests / 6m);
        decimal bananaCost = bananaCount * bananaPrice;
        decimal eggsCost = eggsCount * eggsPrice;
        decimal berriesCost = berriesWeight * berriesPrice;
        decimal total = bananaCost + eggsCost + berriesCost;

        decimal totalCost = total*dessertCount;
        if (totalCost<=moneyAvailable)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalCost-moneyAvailable):f2}lv more.");
        }
    }
}