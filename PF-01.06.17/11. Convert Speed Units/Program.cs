using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float allToSeconds = hours * 3600f + minutes * 60f + seconds;
            float allToHours = hours + minutes/60f + seconds /3600f;
            Console.WriteLine(meters/allToSeconds);
            Console.WriteLine((meters/1000f)/allToHours);
            Console.WriteLine((meters/1609f)/allToHours);
        }
    }
}
