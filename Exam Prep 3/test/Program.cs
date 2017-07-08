.using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('@');
            var leftSide = input[0].ToCharArray().Select(x=>x);
            var rightSide = input[1].ToCharArray();
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < leftSide.Length; i++)
            {
                sumLeft += leftSide[i];
            }
            for (int i = 0; i < rightSide.Length; i++)
            {
                sumRight += rightSide[i];
            }
            if (sumLeft - sumRight >= 0)
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
