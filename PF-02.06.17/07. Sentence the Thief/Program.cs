using System;

namespace _07.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberType = Console.ReadLine();
            byte count = byte.Parse(Console.ReadLine());
            long currentIdMax = long.MinValue;
            for (byte i = 0; i < count; i++)
            {
                long idToCheck = long.Parse(Console.ReadLine());
                if (numberType == "sbyte")
                {
                    if (idToCheck >= sbyte.MinValue && idToCheck <= sbyte.MaxValue && idToCheck > currentIdMax)
                    {
                        currentIdMax = idToCheck;
                    }
                }
                else if (numberType == "int")
                {
                    if (idToCheck >= int.MinValue && idToCheck <= int.MaxValue && idToCheck > currentIdMax)
                    {
                        currentIdMax = idToCheck;
                    }
                }
                else if (numberType == "long")
                {
                    if (idToCheck >= long.MinValue && idToCheck <= long.MaxValue && idToCheck > currentIdMax)
                    {
                        currentIdMax = idToCheck;
                    }
                }
            }
            if (currentIdMax<0)
            {
                long sentence = (long)Math.Ceiling((decimal)currentIdMax / sbyte.MinValue);
                Console.WriteLine($"Prisoner with id {currentIdMax} is sentenced to {sentence} "+(sentence>1?"years":"year"));
            }
            else
            {
                long sentence = (long)Math.Ceiling((decimal)currentIdMax / sbyte.MaxValue);
                Console.WriteLine($"Prisoner with id {currentIdMax} is sentenced to {sentence} "+(sentence>1?"years":"year"));
            }
        }
    }
}
