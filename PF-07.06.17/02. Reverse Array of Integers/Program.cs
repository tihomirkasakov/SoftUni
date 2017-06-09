using System;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            for (int i = number-1; i >=0; i--)
            {
                array [i]= int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
