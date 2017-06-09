using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_26._05._17
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());

            Console.Write("x");
            for (int i = 1; i <= a-2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("x");

            for (int i = 1; i <= (a-3)/2; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int k = a - 2 - (2 * i); k >= 1; k--)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int l = 1; l <= i; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string(' ',a/2)+"x"+new string(' ',a/2));

            for (int i = (a - 3) / 2; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int k = 1; k <= a - 2 - (2 * i); k++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int l = i; l >= 1; l--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.Write("x");
            for (int i = 1; i <= a - 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("x");
        }
    }
}
