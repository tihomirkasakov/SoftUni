using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = double.Parse(Console.ReadLine());
            var minutes = double.Parse(Console.ReadLine());
            var hoursMinutes =(15+minutes)%60;
            if (minutes<=44)
            {
                Console.WriteLine($"{hours}:{minutes + 15}");
            }
            else if (minutes>=45&&minutes<60)
            {
                if (hoursMinutes < 10)
                {
                    Console.WriteLine($"{(hours + 1)%24}:0{hoursMinutes}");
                }
                else
                    Console.WriteLine($"{(hours + 1)%24}:{hoursMinutes}");
            }
        }
    }
}
