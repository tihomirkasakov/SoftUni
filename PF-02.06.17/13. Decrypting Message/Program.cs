using System;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte numberOfChar = byte.Parse(Console.ReadLine());
            string word = "";
            for (int i = 1; i <= numberOfChar; i++)
            {
                char a = char.Parse(Console.ReadLine());
                int b = a + key;
                word += (char)b;
            }
            Console.WriteLine(word);
        }
    }
}
