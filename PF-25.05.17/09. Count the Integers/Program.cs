using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0 ;
            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    var a = int.Parse(Console.ReadLine());
                    count++;
                }
                catch 
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}
