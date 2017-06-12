using System;
using System.Linq;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var index = 0;
            long sum = 0;
            while(true)
            {
                int nextIndex = index;
                sum += array[index];
                index += array[index];
                if (index >array.Length-1)
                {
                    index = nextIndex - array[nextIndex];
                    if (index <0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
