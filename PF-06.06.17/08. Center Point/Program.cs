using System;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = decimal.Parse(Console.ReadLine());
            var y1 = decimal.Parse(Console.ReadLine());
            var x2 = decimal.Parse(Console.ReadLine());
            var y2 = decimal.Parse(Console.ReadLine());

            Check(x1,x2,y1,y2);

        }

        static void Check(decimal x1, decimal x2, decimal y1, decimal y2)
        {
            var firstCoordinates = Math.Abs(x1) + Math.Abs(y1);
            var secondCoordinates = Math.Abs(x2) + Math.Abs(y2);
            if (firstCoordinates<=secondCoordinates)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
