using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBE_19._03._2017E
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var production = double.Parse(Console.ReadLine());
            var unUseful = double.Parse(Console.ReadLine());
            var overallProduction = area * production-unUseful;
            var grapesForRakiya = overallProduction * 0.45;
            var grapesForSale = overallProduction * 0.55;

            Console.WriteLine($"{ (grapesForRakiya/7.5)*9.8:f2}");
            Console.WriteLine($"{grapesForSale*1.5:f2}");
        }
    }
}
