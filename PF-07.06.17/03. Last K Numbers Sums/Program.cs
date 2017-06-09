using System;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[number];
            array[0] = 1;

            for (int i = 1; i < number; i++)
            {
                long sum = 0;
                for (int j = i-k; j <=i-1; j++)
                {
                    if (j>=0)
                    {
                        sum+=array[j];
                    }
                    array[i] = sum;
                }
            }
            Console.Write(string.Join(" ",array));
        }
    }
}
