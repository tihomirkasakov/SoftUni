using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var userIp = new Dictionary<string, Dictionary<string,int>>();

            var input = Console.ReadLine().Split(' ', '=');
            var count = 1;

            while (input[0]!="end")
            {
                var user = input[5];
                var ip = input[1];
                if (!userIp.ContainsKey(user))
                {
                    userIp[user] = new Dictionary<string, int>();
                }
                if (!userIp[user].ContainsKey(ip))
                {
                    userIp[user][ip] = count;
                }
                else
                {
                    userIp[user][ip]+=1;
                }
                input = Console.ReadLine().Split(' ', '=');
            }
            foreach (var item in userIp.OrderBy(x=>x.Key))
            {
                var user = item.Key;
                var Ips = item.Value;
                Console.WriteLine($"{user}:");
                var counter = 1;
                foreach (var kv in Ips)
                {
                    var ips = kv.Key;
                    var ipsTimes = kv.Value;
                    if (Ips.Count==counter)
                    {
                        Console.WriteLine($"{ips} => {ipsTimes}.");
                        break;
                    }
                    Console.Write($"{ips} => {ipsTimes}, ");
                    counter++;
                }
            }
        }
    }
}
