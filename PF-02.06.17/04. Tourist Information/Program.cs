using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string unitOFConvert = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            switch (unitOFConvert)
            {
                case "miles":
                    Console.WriteLine($"{value} {unitOFConvert} = {value*1.6:f2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{value} {unitOFConvert} = {value * 2.54:f2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{value} {unitOFConvert} = {value * 30:f2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{value} {unitOFConvert} = {value *0.91:f2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{value} {unitOFConvert} = {value * 3.8:f2} liters");
                    break;
            }
        }
    }
}
