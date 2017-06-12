using System;
using System.Linq;

namespace PF_12._06._17
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]<0)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
            list.Reverse();
            if (list.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",list));
            }
        }
    }
}
