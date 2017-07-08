using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var beehives = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
        var hornets = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
        long hornetsPower = hornets.Sum();

        for (int i = 0; i < beehives.Count; i++)
        {
            if (hornets.Count==0)
            {
                break;
            }
            if (beehives[i]<hornetsPower)
            {
                beehives.RemoveAt(i);
                i--;
            }
            else if(beehives[i] > hornetsPower)
            {
                beehives[i] -= hornetsPower;
                hornets.RemoveAt(0);
                hornetsPower = hornets.Sum();
            }
            else
            {
                beehives.RemoveAt(i);
                hornets.RemoveAt(0);
                hornetsPower = hornets.Sum();
                i--;
            }
        }
        if (beehives.Count>0)
        {
            Console.WriteLine(string.Join(" ",beehives));
        }
        else
        {
            Console.WriteLine(string.Join(" ",hornets));
        }
    }
}