﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var yearToLive = int.Parse(Console.ReadLine());
            var Ivancho = 18;
            var evenMoney = 0.0;
            var oddMoney = 0.0;
            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    money = money - 12000;
                }
                else
                {
                    var sum = 12000 + 50 * (Ivancho + i - 1800);
                    money = money - sum;
                }
            }
            if (money>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
        }
    }
}
