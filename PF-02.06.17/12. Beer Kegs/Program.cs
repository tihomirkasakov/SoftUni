using System;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfKegs = byte.Parse(Console.ReadLine());
            string biggestKeg = "";
            double largestVolume = double.MinValue;
            for (int i = 1; i <= numberOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double kegVolume = Math.PI * radius * radius * height;
                if (kegVolume>largestVolume)
                {
                    largestVolume = kegVolume;
                    biggestKeg = kegModel;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
