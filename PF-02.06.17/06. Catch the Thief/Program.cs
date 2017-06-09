using System;

namespace _06.Catch_the_Thief
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
                if (numberType=="sbyte")
                {
                    if (idToCheck>=sbyte.MinValue&&idToCheck<=sbyte.MaxValue&&idToCheck>currentIdMax)
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
            Console.WriteLine(currentIdMax);
        }
    }
}
