using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());
            var workHours = workers * workDays*8;
            if (workHours>=hours)
            {
                Console.WriteLine($"{workHours-hours} hours left");
            }
            else
            {
                Console.WriteLine($"{hours-workHours} overtime");
                Console.WriteLine($"Penalties: {(hours-workHours)*workDays}");
            }
        }
    }
}
