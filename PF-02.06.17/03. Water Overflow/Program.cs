using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte poolCapacity = byte.MaxValue;
            byte number = byte.Parse(Console.ReadLine());
            int litersPoored = 0;
            for (byte i = 0; i < number; i++)
            {
                int litersPoor = int.Parse(Console.ReadLine());
                if (litersPoored<=poolCapacity)
                {
                    litersPoored += litersPoor;
                }
                if (litersPoored > poolCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litersPoored -= litersPoor;
                    continue;
                }
            }
            Console.WriteLine(litersPoored);
        }
    }
}
