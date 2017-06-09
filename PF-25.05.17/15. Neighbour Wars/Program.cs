using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshosHealth = 100;
            var goshosHealth = 100;
            var peshosKick = int.Parse(Console.ReadLine());
            var goshosKick = int.Parse(Console.ReadLine());
            var turn = 0;
            while (peshosHealth>0||goshosHealth>0)
            {
                turn++;
                if (turn%2==1)
                {
                    goshosHealth -= peshosKick;
                    if (goshosHealth<=0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }
                else if (turn%2==0)
                {
                    peshosHealth -= goshosKick;
                    if (peshosHealth<=0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                if (turn%3==0)
                {
                    peshosHealth += 10;
                    goshosHealth += 10;
                }
            }
            if (goshosHealth<=0)
            {
                Console.WriteLine($"Pesho won in {turn}th round.");
            }
            else if (peshosHealth<=0)
            {
                Console.WriteLine($"Gosho won in {turn}th round.");
            }
        }
    }
}
