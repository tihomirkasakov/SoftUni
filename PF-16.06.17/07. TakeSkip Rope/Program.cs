using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            int []numbers = input.Where(x => char.IsDigit(x)).Select(x=>int.Parse(x.ToString())).ToArray();
            char []nonNumber = input.Where(x=>!char.IsDigit(x)).ToArray();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i%2==0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }
            var asd = 0;
            string word = string.Empty;
            for (int i = 0; i < takeList.Count; i++)
            {
                int skips = skipList[i];
                int takes = takeList[i];
                word +=new string( nonNumber.Skip(asd).Take(takes).ToArray());
                asd += skips + takes;
            }
            Console.WriteLine(string.Join("",word));
        }
    }
}
