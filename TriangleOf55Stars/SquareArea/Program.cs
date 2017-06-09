using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side lenght=");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.WriteLine("Area=");
            Console.WriteLine(area);
            
        }
    }
}
