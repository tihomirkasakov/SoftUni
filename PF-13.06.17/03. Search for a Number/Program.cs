using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var search = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> finalList = new List<int>();
            var count = 0;

            for (int i = 0; i < search[0]; i++)
            {
                finalList.Add(input[i]);
            }
            for (int i = search[1]-1; i >= 0; i--)
            {
                finalList.RemoveAt(i);
            }
            for (int i = 0; i < finalList.Count; i++)
            {
                if (finalList[i]==search[2])
                {
                    count++;
                    if (count>0)
                    {
                        Console.WriteLine("YES!");
                        break;
                    }
                }
            }
            if (count==0)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
