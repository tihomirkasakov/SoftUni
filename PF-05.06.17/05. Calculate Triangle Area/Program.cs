using System;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var areaOfTriangle = TriangleArea(width, height);
            Console.WriteLine(areaOfTriangle);
        }

        static double TriangleArea(double width, double height)
        {
            var area = (width * height) / 2;
            return area;
        }
    }
}
