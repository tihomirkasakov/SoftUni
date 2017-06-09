using System;

namespace PF_07._06._17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day>=1&&day<=7)
            {
                Console.WriteLine(array[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
