using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            if (minutes+30>=60)
            {
                hours += 1;
                minutes -= 30;
                if (hours == 24)
                {
                    hours = hours - 24;
                }
            }
            else
            {
                minutes += 30;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
