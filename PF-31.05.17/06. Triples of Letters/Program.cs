using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (char i = 'a'; i <= 'a'+a-1; i++)
            {
                for (char j = 'a'; j <= 'a'+a-1; j++)
                {
                    for (char k = 'a'; k <= 'a'+a-1; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
