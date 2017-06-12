using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long earned = 0;
            long expenses = 0;

            string[] input = Console.ReadLine().Split();

            while (input[0] != "Jail" && input[1] != "Time")
            {
                expenses += int.Parse(input[1]);
                char []chars = input[0].ToCharArray();

                for (int i = 0; i < chars.Length; i++)
                {

                    if (chars[i]=='%')
                    {
                        earned += priceArray[0];
                    }
                    else if (chars[i]=='$')
                    {
                        earned += priceArray[1];
                    }
                }
                input = Console.ReadLine().Split();
            }
            if (earned >= expenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {earned - expenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expenses - earned}.");
            }

        }
    }
}
