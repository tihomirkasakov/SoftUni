using System;

namespace _02.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('@');
            var leftSide = input[0].ToCharArray();
            var rightSide = input[1].ToCharArray();
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < leftSide.Length; i++)
            {
                sumLeft += leftSide[i];
            }
            for (int i = 0; i < rightSide.Length; i++)
            {
                sumRight+= rightSide[i];
            }
            if (sumLeft-sumRight>=0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
