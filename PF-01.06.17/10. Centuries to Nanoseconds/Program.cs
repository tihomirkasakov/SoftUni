using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = Math.Floor((double)years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            double milliSeconds = seconds * 1000;
            decimal microSeconds = (decimal)milliSeconds * 1000;
            decimal nanoSeconds = microSeconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");
        }
    }
}
