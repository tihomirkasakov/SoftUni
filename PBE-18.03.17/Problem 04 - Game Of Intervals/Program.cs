using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfmoves = int.Parse(Console.ReadLine());
            var startNumber = 0.0;
            var counter1 = 0.0;
            var counter2 = 0.0;
            var counter3 = 0.0;
            var counter4 = 0.0;
            var counter5 = 0.0;
            var counter6 = 0.0;

            for (int i = 0; i < numberOfmoves; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number >= 0 && number < 10)
                {
                    startNumber = startNumber+number * 0.2;
                    if (number==0)
                    {
                        counter1 += 1;
                    }
                    else
                    {
                        counter1 = counter1 + number / number;
                    }
                }
                else if (number>=10&&number<20)
                {
                    startNumber = startNumber + number * 0.3;
                    counter2 = counter2 + number / number;
                }
                else if (number >= 20 && number < 30)
                {
                    startNumber = startNumber + number * 0.4;
                    counter3 = counter3 + number / number;
                }
                else if (number >= 30 && number < 40)
                {
                    startNumber = startNumber + 50;
                    counter4 = counter4 + number / number;
                }
                else if (number >= 40 && number <= 50)
                {
                    startNumber = startNumber + 100;
                    counter5 = counter5 + number / number;
                }
                else
                {
                    startNumber = startNumber / 2;
                    counter6 = counter6 + number / number;
                }
            }
            

            Console.WriteLine($"{startNumber:f2}");
            Console.WriteLine($"From 0 to 9: {counter1/numberOfmoves*100:f2}%");
            Console.WriteLine($"From 10 to 19: {counter2 / numberOfmoves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {counter3 / numberOfmoves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {counter4 / numberOfmoves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {counter5 / numberOfmoves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {counter6 / numberOfmoves * 100:f2}%");
        }
    }
}
