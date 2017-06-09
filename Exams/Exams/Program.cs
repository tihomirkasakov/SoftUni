using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var yoan = double.Parse(Console.ReadLine());
            var komisionna = double.Parse(Console.ReadLine());
            var dolar = 1.76;
            var evro = 1.95;
            var sum=(bitcoins*1168/1.95)+(yoan*0.15*1.76/1.95);
            Console.WriteLine(sum-(sum*komisionna/100));
        }
    }
}
