using System;
using System.Linq;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var detonationPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (detonationPower[0]==input[i])
                {
                    var leftDetonation = i - detonationPower[1];
                    var rightDetonation = i + detonationPower[1];
                    if (leftDetonation<0)
                    {
                        leftDetonation = 0;
                    }
                    if (rightDetonation>=input.Count)
                    {
                        rightDetonation = input.Count - 1;
                    }
                    for (int j = rightDetonation; j >= leftDetonation; j--)
                    {
                        input.RemoveAt(j);
                    }
                    i = 0;
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }
            Console.WriteLine(sum);
        }
    }
}
