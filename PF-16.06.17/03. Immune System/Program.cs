using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int Starthealth = int.Parse(Console.ReadLine());
            double health = Starthealth;
            var virusName = Console.ReadLine();
            List<string> viruses = new List<string>();
            while (health>0)
            {
                if (virusName=="end")
                {
                    Console.WriteLine($"Final Health: {health}");
                    break;
                }
                var sum = 0;
                foreach (var item in virusName)
                {
                    sum += item;
                }
                var lenght = virusName.Length;
                var strength = sum / 3;
                var timeForDefeat =0;

                if (!viruses.Contains(virusName))
                {
                    timeForDefeat = strength * lenght;
                    health -= timeForDefeat;
                }
                else
                {
                    timeForDefeat = strength * lenght / 3;
                    health -= timeForDefeat;
                }
                Console.WriteLine($"Virus {virusName}: {strength} => {timeForDefeat} seconds");

                if (health < 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }

                var minutes = timeForDefeat/60;
                var seconds = timeForDefeat%60;
                Console.WriteLine($"{virusName} defeated in {minutes}m {seconds}s.");
                Console.WriteLine($"Remaining health: {health}");

                health *= 1.2;
                if (health>Starthealth)
                {
                    health = Starthealth;
                }
                health=(int)health;
                viruses.Add(virusName);
                virusName = Console.ReadLine();
            }
        }
    }
}
