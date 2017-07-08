using System;
using System.Linq;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            var ladybugsPositions = new int[lenght];
            var ladybugs = Console.ReadLine().Split().Select(int.Parse).Where(l=>l>=0&l<lenght).ToArray();

            for (int i = 0; i < ladybugs.Length; i++)
            {
                ladybugsPositions[ladybugs[i]] = 1;
            }
            var fly = Console.ReadLine();

            while (fly!="end")
            {
                var command = fly.Split();
                var index = int.Parse(command[0]);
                var direction = command[1];
                var move = int.Parse(command[2]);

                if (index<0||index>=ladybugsPositions.Length)
                {
                    fly = Console.ReadLine();
                    continue;
                }

                if (ladybugsPositions[index]==0)
                {
                    fly = Console.ReadLine();
                    continue;

                }
                var inArray = true;
                ladybugsPositions[index] = 0;
                while (inArray)
                {
                    if (direction=="right")
                    {
                        index += move;
                    }
                    else if (direction=="left")
                    {
                        index -= move;
                    }

                    if (index<0||index>=ladybugsPositions.Length)
                    {
                        inArray = false;
                        continue;
                    }
                    if (ladybugsPositions[index]==1)
                    {
                        continue;
                    }
                    else
                    {
                        ladybugsPositions[index] = 1;
                        inArray = false;
                    }
                }
                fly = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",ladybugsPositions));
        }
    }
}
