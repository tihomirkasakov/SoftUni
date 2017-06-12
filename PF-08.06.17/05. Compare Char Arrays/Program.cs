using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var shorterArray = Math.Min(array1.Length, array2.Length);

             for (int i = 0; i < shorterArray; i++)
             {
                 if (array1[i]<array2[i])
                 {
                    Console.WriteLine(string.Join("",array1));
                    Console.WriteLine(string.Join("",array2));
                    break;
                 }
                else if (array2[i]<array1[i])
                {
                    Console.WriteLine(string.Join("", array2));
                    Console.WriteLine(string.Join("", array1));
                    break;
                }
                if (i==shorterArray-1)
                {
                    Console.WriteLine(string.Join("",array1.Length>array2.Length?array2:array1));
                    Console.WriteLine(string.Join("", array1.Length > array2.Length ? array1 : array2));
                }
            }
        }
    }
}
