using System;

namespace _15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            byte countOpening = 0;
            byte countClosing = 0;
            for (int i = 1; i <= numberOfLines; i++)
            {
                string stringToCheck = Console.ReadLine();
                if (stringToCheck=="(")
                {
                    countOpening++;
                }
                else if (stringToCheck == ")")
                {
                    countClosing++;
                }
                if (countClosing > countOpening)
                {
                    break;
                }
            }
            if (countOpening==countClosing)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
