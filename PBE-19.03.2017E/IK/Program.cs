using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 1; i <= n; i++)
            {
                count += i+13;
            }
            Console.WriteLine(count);
        }
    }
}
