using System;
using System.Linq;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            int[] newArray =new int[array.Length-1];
            if (array.Length==1)
            {
                Console.WriteLine($"{string.Join("",array)} is already condensed to number");
            }
            else
            {
                while (array.Length > 1)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        newArray[i] = array[i] + array[i + 1];
                    }
                    Array.Resize(ref array, array.Length - 1);
                    Array.Copy(newArray, array, array.Length);
                }
                Console.WriteLine(string.Join("", array));
            }
        }
    }
}
