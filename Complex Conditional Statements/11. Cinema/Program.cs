using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectType = Console.ReadLine();
            var row = int.Parse(Console.ReadLine());
            var colomn = int.Parse(Console.ReadLine());

            if(projectType=="Premiere")
            {
                Console.WriteLine("{0:f2}",row*colomn*12.00);
            }
            else if(projectType=="Normal")
            {
                Console.WriteLine("{0:f2}",row*colomn*7.5);
            }
            else if(projectType=="Discount")
            {
                Console.WriteLine("{0:f2}",row*colomn*5);
            }
        }
    }
}
