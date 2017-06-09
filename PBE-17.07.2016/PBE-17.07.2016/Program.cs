using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBE_17._07._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var yoans = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());
            var bitcoinsToEuro = bitcoins * (1168 / 1.95);
            var yoanToEuro = yoans * (0.15 * 1.76 / 1.95);
            var euros = (bitcoinsToEuro + yoanToEuro) * (1 - (commision / 100));
            Console.WriteLine(euros);
        }
    }
}
