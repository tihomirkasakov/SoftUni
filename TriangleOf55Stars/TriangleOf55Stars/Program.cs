using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 9; i++)
            {
                for (var j = i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
        }
    }
}
