﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > max)
                    max = number;
            }
            Console.WriteLine(max);
        }
    }
}
