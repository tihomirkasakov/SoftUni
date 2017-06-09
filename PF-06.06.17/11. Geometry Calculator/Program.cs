using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double areaOfFigure = CheckTypeOfFigure(figureType);
            Console.WriteLine($"{areaOfFigure:f2}");
        }

        static double CheckTypeOfFigure(string figureType)
        {
            if (figureType=="triangle")
            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double heightOfTriangle = double.Parse(Console.ReadLine());
                double areaOfTriangle = sideOfTriangle * heightOfTriangle/2;
                return areaOfTriangle;
            }
            else if (figureType=="square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                double areaOfSquare = sideOfSquare * sideOfSquare;
                return areaOfSquare;
            }
            else if (figureType=="rectangle")
            {
                double widthOfRectangle = double.Parse(Console.ReadLine());
                double heightOfRectangle = double.Parse(Console.ReadLine());
                double areaOfRectangle = widthOfRectangle * heightOfRectangle;
                return areaOfRectangle;
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());
                double areaOfCircle = Math.PI * radius * radius;
                return areaOfCircle;
            }
        }
    }
}
