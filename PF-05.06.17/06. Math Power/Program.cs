using System;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            var numberOnPower = numberPower(number, power);
            Console.WriteLine(numberOnPower);
        }

        static double numberPower(double number, double power)
        {
            double calculation = 1;
            for (int i = 1; i <=power; i++)
            {
                calculation *= number;
            }
            return calculation;
        }
    }
}
