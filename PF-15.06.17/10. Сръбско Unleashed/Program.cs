using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var singerDict = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArr = input.Split("@".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string singerName = inputArr[0].Trim();
                string[] concertInfo = inputArr[1].Trim().Split().ToArray();
                int ticketPrice = int.Parse(concertInfo[concertInfo.Length - 2]);
                int ticketCount = int.Parse(concertInfo[concertInfo.Length - 1]);
                long totalMoney = ticketCount * ticketPrice;

                string venue = string.Empty;
                for (int i = 0; i < concertInfo.Length - 2; i++)
                {
                    venue += " " + concertInfo[i];
                }

                venue = venue.Trim();

                if (!singerDict.ContainsKey(venue))
                {
                    singerDict[venue] = new Dictionary<string, long>();
                }

                if (!singerDict[venue].ContainsKey(singerName))
                {
                    singerDict[venue][singerName] = totalMoney;
                }
                else
                {
                    singerDict[venue][singerName] += totalMoney;
                }

                input = Console.ReadLine();
            }

            foreach (var record in singerDict)
            {
                Console.WriteLine($"{record.Key}");
                Console.Write($"#  {string.Join("#  ", record.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key} -> {x.Value}\n"))}");
            }
        }
    }
}
