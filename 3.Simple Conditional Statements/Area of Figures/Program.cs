using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input=="square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a*a);
            }
            else if(input=="rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a*b),3));
            }
            else if(input=="circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((Math.PI*r*r),3));
            }
            else if(input=="triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine(a*h/2);
            }
        }
    }
}
