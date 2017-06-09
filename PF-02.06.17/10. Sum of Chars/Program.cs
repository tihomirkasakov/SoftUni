using System;

namespace _10.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte quality = byte.Parse(Console.ReadLine());
            short sum = 0;
            for (byte i = 0; i < quality; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += (short)letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
