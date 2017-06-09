using System;
using System.Linq;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int[] array = input.Split(' ').Select(int.Parse).ToArray();

            if (array.Length==1)
            {
                Console.WriteLine("{ "+$"{string.Join("",array)} "+"}");
            }
            else if(array.Length%2==0)
            {
                Console.WriteLine("{"+$" {array[array.Length/2-1]}, {array[array.Length/2]} "+"}");
            }
            else if (array.Length%2==1)
            {
                Console.WriteLine("{" + $" {array[array.Length / 2 - 1]}, {array[array.Length / 2]}, {array[array.Length/2+1]} " + "}");
            }
        }
    }
}
