using System;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var power = 0;
            var startIndexOfBomb = 0;
            var lastIndexOfBomb = 0;
            while ((startIndexOfBomb=input.IndexOf('<',startIndexOfBomb)) !=-1&&(lastIndexOfBomb=input.IndexOf('>',startIndexOfBomb))!=-1)
            {
                var bomb = input.Substring(startIndexOfBomb + 1, 2).ToCharArray();
                power = Math.Abs(bomb[0]-bomb[1]);
                var left = Math.Max(0, startIndexOfBomb - power);
                var right = Math.Min(lastIndexOfBomb + power, input.Length-1);
                input = input.Remove(left, right - left+1);
                input = input.Insert(left, new string('_', right - left+1));
            }
            Console.WriteLine(input);
        }
    }
}
