using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = char.Parse(Console.ReadLine());
            var b = char.Parse(Console.ReadLine());
            var c = char.Parse(Console.ReadLine());

            for (char i = a; i <= b ; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char k = a; k <= b; k++)
                    {
                        if (i==c||j==c||k==c)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
