using System;
using System.Linq;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var start = 0;
            var length = 1;
            var bestStart = 0;
            var bestLength = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i]==array[i-1])
                {
                    length++;
                    if (length>bestLength)
                    {
                        bestStart = start;
                        bestLength = length;
                    }
                }
                else
                {
                    start = i;
                    length = 1;
                }
            }
            for (int i = bestStart; i < bestStart+bestLength; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
