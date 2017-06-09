using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double peopleInElevator = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(numberOfPeople/peopleInElevator));
        }
    }
}
