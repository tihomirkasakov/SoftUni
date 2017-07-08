using System;
using System.Linq;

namespace _02.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine().Split(':').Select(long.Parse).ToArray();
            int steps = int.Parse(Console.ReadLine());
            double secondsForEachStep = double.Parse(Console.ReadLine());
            double timeForWalking = steps * secondsForEachStep;
            long seconds = time[2] + (long)Math.Round(timeForWalking);

            if (seconds>=60)
            {
                long minutes = time[1]+(seconds / 60);
                seconds %= 60;
                time[2] = seconds;
                time[1] = minutes;
                if (minutes>=60)
                {
                    var hours = time[0] + minutes / 60;
                    minutes %= 60;
                    time[1] = minutes;
                    time[0] = hours;
                    if (hours>=24)
                    {
                        hours %= 24;
                        time[0] = hours;
                    }
                }
            }
            Console.WriteLine($"Time Arrival: {time[0]:d2}:{time[1]:d2}:{time[2]:d2}");
        }
    }
}
