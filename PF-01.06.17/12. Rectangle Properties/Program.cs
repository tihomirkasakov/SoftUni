using System;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double perimeter = 2 * firstSide + 2 * secondSide;
            double area = firstSide * secondSide;
            double diagonal = Math.Sqrt((firstSide * firstSide) + (secondSide * secondSide));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
