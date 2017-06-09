using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            string unit1 = (Console.ReadLine());
            string unit2 = (Console.ReadLine());
            if (unit1 == "mm")
            {
                var meter = a / 1000;
                if (unit2 == "m")
                {
                    Console.WriteLine(meter);
                }
                else if (unit2 == "cm")
                {
                    Console.WriteLine(meter * 100);
                }
                else if (unit2 == "mi")
                {
                    Console.WriteLine(meter * 0.000621371192);
                }
                else if (unit2 == "in")
                {
                    Console.WriteLine(meter * 39.3700787);
                }
                else if (unit2 == "km")
                {
                    Console.WriteLine(meter * 0.001);
                }
                else if (unit2 == "ft")
                {
                    Console.WriteLine(meter * 3.2808399);
                }
                else if (unit2 == "yd")
                {
                    Console.WriteLine(meter * 1.0936133);
                }
                else if(unit2=="mm")
                {
                    Console.WriteLine(a);
                }

            }
            if (unit1 == "cm")
            {
                var meter = a / 100;
                if (unit2 == "m")
                {
                    Console.WriteLine(meter);
                }
                else if (unit2 == "mm")
                {
                    Console.WriteLine(meter * 1000);
                }
                else if (unit2 == "mi")
                {
                    Console.WriteLine(meter * 0.000621371192);
                }
                else if (unit2 == "in")
                {
                    Console.WriteLine(meter * 39.3700787);
                }
                else if (unit2 == "km")
                {
                    Console.WriteLine(meter * 0.001);
                }
                else if (unit2 == "ft")
                {
                    Console.WriteLine(meter * 3.2808399);
                }
                else if (unit2 == "yd")
                {
                    Console.WriteLine(meter * 1.0936133);
                }
                else if(unit2=="cm")
                {
                    Console.WriteLine(a);
                }
            }
            if (unit1 == "mi")
            {
                var meter = a / 0.000621371192;
                if (unit2 == "m")
                {
                    Console.WriteLine(meter);
                }
                else if (unit2 == "cm")
                {
                    Console.WriteLine(meter * 100);
                }
                else if (unit2 == "mm")
                {
                    Console.WriteLine(meter * 1000);
                }
                else if (unit2 == "in")
                {
                    Console.WriteLine(meter * 39.3700787);
                }
                else if (unit2 == "km")
                {
                    Console.WriteLine(meter * 0.001);
                }
                else if (unit2 == "ft")
                {
                    Console.WriteLine(meter * 3.2808399);
                }
                else if (unit2 == "yd")
                {
                    Console.WriteLine(meter * 1.0936133);
                }
                else if(unit2=="mi")
                {
                    Console.WriteLine(a);
                }
            }
            if (unit1 == "in")
            {
                var meter = a / 39.3700787;
                if (unit2 == "m")
                {
                    Console.WriteLine(meter);
                }
                else if (unit2 == "cm")
                {
                    Console.WriteLine(meter * 100);
                }
                else if (unit2 == "mi")
                {
                    Console.WriteLine(meter * 0.000621371192);
                }
                else if (unit2 == "mm")
                {
                    Console.WriteLine(meter * 1000);
                }
                else if (unit2 == "km")
                {
                    Console.WriteLine(meter * 0.001);
                }
                else if (unit2 == "ft")
                {
                    Console.WriteLine(meter * 3.2808399);
                }
                else if (unit2 == "yd")
                {
                    Console.WriteLine(meter * 1.0936133);
                }
                else if (unit2=="in")
                {
                    Console.WriteLine(a);
                }
            }
            if (unit1 == "km")
            {
                var meter = a / 0.001;
                if (unit2 == "m")
                {
                    Console.WriteLine(meter);
                }
                else if (unit2 == "cm")
                {
                    Console.WriteLine(meter * 100);
                }
                else if (unit2 == "mi")
                {
                    Console.WriteLine(meter * 0.000621371192);
                }
                else if (unit2 == "mm")
                {
                    Console.WriteLine(meter * 1000);
                }
                else if (unit2 == "in")
                {
                    Console.WriteLine(meter * 39.3700787);
                }
                else if (unit2 == "ft")
                {
                    Console.WriteLine(meter * 3.2808399);
                }
                else if (unit2 == "yd")
                {
                    Console.WriteLine(meter * 1.0936133);
                }
                else if(unit2=="km")
                {
                    Console.WriteLine(a);
                }
            }
            if (unit1 == "ft")
            {
                var meter = a / 3.2808399;
                if (unit2 == "m")
                {
                    Console.WriteLine(meter);
                }
                else if (unit2 == "cm")
                {
                    Console.WriteLine(meter * 100);
                }
                else if (unit2 == "mi")
                {
                    Console.WriteLine(meter * 0.000621371192);
                }
                else if (unit2 == "mm")
                {
                    Console.WriteLine(meter * 1000);
                }
                else if (unit2 == "in")
                {
                    Console.WriteLine(meter * 39.3700787);
                }
                else if (unit2 == "km")
                {
                    Console.WriteLine(meter * 0.001);
                }
                else if (unit2 == "yd")
                {
                    Console.WriteLine(meter * 1.0936133);
                }
                else if(unit2=="ft")
                {
                    Console.WriteLine(a);
                }
            }
            if (unit1 == "yd")
            {
                var meter = a / 1.0936133;
                if (unit2 == "m")
                {
                    Console.WriteLine(meter);
                }
                else if (unit2 == "cm")
                {
                    Console.WriteLine(meter * 100);
                }
                else if (unit2 == "mi")
                {
                    Console.WriteLine(meter * 0.000621371192);
                }
                else if (unit2 == "mm")
                {
                    Console.WriteLine(meter * 1000);
                }
                else if (unit2 == "in")
                {
                    Console.WriteLine(meter * 39.3700787);
                }
                else if (unit2 == "ft")
                {
                    Console.WriteLine(meter * 3.2808399);
                }
                else if (unit2 == "km")
                {
                    Console.WriteLine(meter * 0.001);
                }
                else if(unit2=="yd")
                {
                    Console.WriteLine(a);
                }
            }
            if (unit1 == "m")
            {
                var meter = a ;
                if (unit2 == "m")
                {
                    Console.WriteLine(a);
                }
                else if (unit2 == "cm")
                {
                    Console.WriteLine(meter * 100);
                }
                else if (unit2 == "mi")
                {
                    Console.WriteLine(meter * 0.000621371192);
                }
                else if (unit2 == "mm")
                {
                    Console.WriteLine(meter * 1000);
                }
                else if (unit2 == "in")
                {
                    Console.WriteLine(meter * 39.3700787);
                }
                else if (unit2 == "ft")
                {
                    Console.WriteLine(meter * 3.2808399);
                }
                else if (unit2 == "km")
                {
                    Console.WriteLine(meter * 0.001);
                }
                else if (unit2=="yd")
                {
                    Console.WriteLine(meter* 1.0936133);
                }
            }
        }
    }
}
