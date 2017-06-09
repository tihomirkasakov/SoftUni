using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();
            var sum = (firstNumber + secondNumber);
            Console.WriteLine(sum);
        }
    }
}
