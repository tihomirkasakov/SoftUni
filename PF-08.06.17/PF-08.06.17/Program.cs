using System;

namespace PF_08._06._17
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split();
            var array2 = Console.ReadLine().Split();
            var countLeft = 0;
            var countRight = 0;
            var shorterArray = Math.Min(array1.Length, array2.Length);

            for (int i = 0; i < shorterArray; i++)
            {
                if (array1[i]==array2[i])
                {
                    countLeft++;
                }
                if (array1[array1.Length-1 - i] == array2[array2.Length-1 - i])
                {
                    countRight++;
                }
            }
            if (countLeft!=0)
            {
                Console.WriteLine(countLeft);
            }
            else
            {
                Console.WriteLine(countRight);
            }
        }
    }
}
