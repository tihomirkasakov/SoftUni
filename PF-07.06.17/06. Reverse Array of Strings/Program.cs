using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] text = input.Split(' ');
            string[] reversed = text.Reverse().ToArray();
            Console.WriteLine(string.Join(" ",reversed));
        }
    }
}
