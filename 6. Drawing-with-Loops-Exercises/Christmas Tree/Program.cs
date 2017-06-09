using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n+1; row++)
            {
                Console.Write(new string(' ', n - row));
                for (int left = 0; left < row; left++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int right = 0; right < row; right++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
