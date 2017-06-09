using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            var electricityOverall = 0.0;
            var water = 20;
            var internet = 15;
            var others = 0.0;

            for (int i = 0; i < months; i++)
            {
                var currentElectricity = 0.0;
                var currencyBill = double.Parse(Console.ReadLine());
                electricityOverall += currencyBill;
                currentElectricity += currencyBill;
                others += (currentElectricity + water + internet) * 1.2;
            }
            var waterOverall = water * months;
            var internetOverall = internet * months;
            Console.WriteLine($"Electricity: {electricityOverall:f2} lv");
            Console.WriteLine($"Water: {waterOverall:f2} lv");
            Console.WriteLine($"Internet: {internetOverall:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {(electricityOverall+waterOverall+internetOverall+others)/months:f2} lv");
        }
    }
}
