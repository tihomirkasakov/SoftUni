using System;
using System.Linq;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var keyElement = array[i];
                int leftSum = 0;
                int rightSum = 0;

                if (i == 0 && array.Length == 1)
                {
                    Console.WriteLine("0");
                    count++;
                    break;
                }
                for (int left = -1; left <= i - 1; left++)
                {
                    if (left < 0)
                    {
                        continue;
                    }
                    else
                    {
                        leftSum += array[left];
                    }
                }
                for (int right = array.Length - 1; right > i; right--)
                {
                    rightSum += array[right];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
