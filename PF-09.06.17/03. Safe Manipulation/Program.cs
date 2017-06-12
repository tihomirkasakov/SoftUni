using System;
using System.Linq;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            while(true)
            {
                string[] commandArray = Console.ReadLine().Split();

                if (commandArray[0] == "END")
                {
                    break;
                }
                else if (commandArray[0] == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (commandArray[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (commandArray[0] == "Replace")
                {
                    var numberOfElement = int.Parse(commandArray[1]);
                    if (numberOfElement > array.Length - 1 || numberOfElement < 0)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    array[numberOfElement] = commandArray[2];
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
