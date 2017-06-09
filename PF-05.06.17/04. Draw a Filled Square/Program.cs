using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFigure(n);
        }

        static void PrintFigure(int n)
        {
            PrintHeader(1,n);
            PrintBody(n);
            PrintHeader(1,n);
        }

        static void PrintHeader(int start, int end)
        {
            for (int i = start; i <= 2*end; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void PrintBody(int n)
        {
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <=n-1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
