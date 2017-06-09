using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var farenheit = celsius * 1.8 + 32;
            Console.WriteLine(Math.Round(farenheit, 2));
        }
    }
}
