using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lenght in cm=");
            var cm = double.Parse(Console.ReadLine());
            var cmtoin = cm * 2.54;
            Console.WriteLine("Lenght in inches=");
            Console.WriteLine(cmtoin);
        }
    }
}
