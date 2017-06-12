using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split('|').ToList();
            var newList = new List<int>();

            lists.Reverse();
            foreach (var item in lists)
            {
                var items = item.Split().ToList();
                foreach (var number in items)
                {
                    if (number!=string.Empty)
                    {
                        newList.Add(int.Parse(number));
                    }
                }
            }
            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
