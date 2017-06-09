﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            byte numberOfLines = byte.Parse(Console.ReadLine());
            byte positionBoat1 = 0;
            byte positionBoat2 = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                string currentCommand = Console.ReadLine();
                if (currentCommand == "UPGRADE")
                {
                    boat1 += (char)3;
                    boat2 += (char)3;
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        positionBoat1 += (byte)currentCommand.Length;
                        if (positionBoat1 >= 50)
                        {
                            break;
                        }
                    }
                    else
                    {
                        positionBoat2 += (byte)currentCommand.Length;
                        if (positionBoat2 >= 50)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
