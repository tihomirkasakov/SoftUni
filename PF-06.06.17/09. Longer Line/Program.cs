using System;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLineX1 = decimal.Parse(Console.ReadLine());
            var firstLineY1 = decimal.Parse(Console.ReadLine());
            var firstLineX2 = decimal.Parse(Console.ReadLine());
            var firstLineY2 = decimal.Parse(Console.ReadLine());

            var secondLineX1 = decimal.Parse(Console.ReadLine());
            var secondLineY1 = decimal.Parse(Console.ReadLine());
            var secondLineX2 = decimal.Parse(Console.ReadLine());
            var secondLineY2 = decimal.Parse(Console.ReadLine());

            decimal firstLineLenght = LenghtOfFirstLine(firstLineX1, firstLineX2, firstLineY1, firstLineY2);
            decimal secondLineLenght = LenghtOfSecondLine(secondLineX1, secondLineX2, secondLineY1, secondLineY2);
            decimal x1, x2, y1, y2;

            x1 = (firstLineLenght >= secondLineLenght ? firstLineX1 : secondLineX1);
            y1 = (firstLineLenght >= secondLineLenght ? firstLineY1 : secondLineY1);
            x2 = (firstLineLenght >= secondLineLenght ? firstLineX2 : secondLineX2);
            y2 = (firstLineLenght >= secondLineLenght ? firstLineY2 : secondLineY2);

            Check(x1,x2,y1,y2);

        }

        static decimal LenghtOfFirstLine(decimal firstLineX1, decimal firstLineX2, decimal firstLineY1, decimal firstLineY2)
        {
            var firstPoint = Math.Abs(firstLineX1) + Math.Abs(firstLineY1);
            var secondPoint = Math.Abs(firstLineX2) + Math.Abs(firstLineY2);
            var firstLineLenght = firstPoint + secondPoint;
            return firstLineLenght;
        }

        static decimal LenghtOfSecondLine(decimal secondLineX1, decimal secondLineX2, decimal secondLineY1, decimal secondLineY2)
        {
            var firstPoint = Math.Abs(secondLineX1) + Math.Abs(secondLineY1);
            var secondPoint = Math.Abs(secondLineX2) + Math.Abs(secondLineY2);
            var secondLineLenght = firstPoint + secondPoint;
            return secondLineLenght;
        }


        static void Check(decimal x1, decimal x2, decimal y1, decimal y2)
        {
            var firstCoordinates = Math.Abs(x1) + Math.Abs(y1);
            var secondCoordinates = Math.Abs(x2) + Math.Abs(y2);
            if (firstCoordinates <= secondCoordinates)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
