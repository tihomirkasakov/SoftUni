using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfInputs = int.Parse(Console.ReadLine());
            var userIpDuration = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                var input = Console.ReadLine().Split();
                var user = input[1];
                var ip = input[0];
                var duration = int.Parse(input[2]);
                if (!userIpDuration.ContainsKey(user))
                {
                    userIpDuration[user] = new SortedDictionary<string, int>();
                }
                if (!userIpDuration[user].ContainsKey(ip))
                {
                    userIpDuration[user][ip] = duration;
                }
                else
                {
                    userIpDuration[user][ip] += duration;
                }
            }
            foreach (var userIpDurationKV in userIpDuration)
            {
                var user = userIpDurationKV.Key;
                var ipDuration = userIpDurationKV.Value;
                var ips = userIpDurationKV.Value.Keys.ToArray();
                var sum = 0;
                foreach (var kv in ipDuration)
                {
                    var duration = kv.Value;
                    sum += duration;
                }
                Console.WriteLine($"{user}: {sum} [{string.Join(", ", ips)}]");
            }
        }
    }
}
