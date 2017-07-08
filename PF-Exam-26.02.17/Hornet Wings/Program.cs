using System;

class Program
{
    static void Main()
    {
        var wingFlaps = int.Parse(Console.ReadLine());
        var distance = double.Parse(Console.ReadLine());
        var wingFlapsBeforeRest = long.Parse(Console.ReadLine());
        double distanceTravel = wingFlaps * distance / 1000;
        var secondsInrest = wingFlaps / wingFlapsBeforeRest * 5;
        var secondsTravel = wingFlaps / 100;
        var totalTime = secondsInrest + secondsTravel;

        Console.WriteLine($"{distanceTravel:f2} m.");
        Console.WriteLine($"{totalTime} s.");
    }
}