using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bpm = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());
            var bars = numberOfBeats /4;
            var seconds = Math.Floor((numberOfBeats / bpm)*60);
            var minutes = 0;
            while (seconds>59)
            {
                minutes++;
                seconds -= 60;
            }
            Console.WriteLine($"{Math.Round(bars,1)} bars - {minutes}m {seconds}s");
        }
    }
}
