using System;
using System.Linq;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] commandArray = Console.ReadLine().Split();
                if (commandArray[0].ToLower()=="reverse")
                {
                    Array.Reverse(array);
                }
                else if (commandArray[0].ToLower()=="distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (commandArray[0].ToLower()=="replace")
                {
                    var numberOfElement = int.Parse(commandArray[1]);
                    array[numberOfElement] = commandArray[2];
                }
            }
            Console.WriteLine(string.Join(", ",array));
        }
    }
}
