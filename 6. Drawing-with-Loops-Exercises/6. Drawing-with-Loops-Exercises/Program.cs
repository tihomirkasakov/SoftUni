using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Drawing_with_Loops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int col = 0; col < 10; col++)
            {
                for (int row = 0; row < 10; row++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

        }
    }
}
