using System;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var maxCount = 0;
            var printNumber = 0;

            for (int i = 0; i <array.Length; i++)
            {
                var count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[array.Length - 1 - i] == array[j])
                    {
                        count++;
                    }
                }
                if (count>=maxCount)
                {
                    maxCount = count;
                    printNumber = array[array.Length-1-i];

                }
            }
            Console.WriteLine(printNumber);
        }
    }
}
