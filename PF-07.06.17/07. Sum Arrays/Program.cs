using System;
using System.Linq;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            string[] text1 = input1.Split(' ');
            string[] text2 = input2.Split(' ');
            int[] array1 = text1.Select(int.Parse).ToArray();
            int[] array2 = text2.Select(int.Parse).ToArray();

            int[] arrayAnswer = new int[Math.Max(array1.Length, array2.Length)];

                for (int i = 0; i < arrayAnswer.Length; i++)
                {
                arrayAnswer[i] = array1[i%array1.Length] + array2[i%array2.Length];
                }
            Console.WriteLine(string.Join(" ",arrayAnswer));
        }
    }
}
