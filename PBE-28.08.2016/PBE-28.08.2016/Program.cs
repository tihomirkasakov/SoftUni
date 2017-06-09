using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBE_28._08._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var dollarCourse = double.Parse(Console.ReadLine());

            var monthSalary = workDays * moneyPerDay;
            var yearSalary = (monthSalary * 12 + (2.5 * monthSalary)) * 0.75;
            Console.WriteLine($"{(yearSalary * dollarCourse)/365:f2}");
        }
    }
}
