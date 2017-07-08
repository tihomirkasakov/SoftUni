using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var pattern = @"(?<act>\d+)\s\=\s(?<legName>.+)\s\-\>\s(?<soldType>.+)\:(?<count>\d+)";
        var legionActivity = new Dictionary<string, int>();
        var legionTypeCount = new Dictionary<string, Dictionary<string, long>>();
        for (int i = 0; i < n; i++)
        {
            var hornetArmada = Console.ReadLine();
            var match = Regex.Match(hornetArmada, pattern);
            if (!match.Success)
            {
                continue;
            }
            var activity = int.Parse(match.Groups["act"].Value);
            var legionName = match.Groups["legName"].Value;
            var soldierType = match.Groups["soldType"].Value;
            var count = int.Parse(match.Groups["count"].Value);

            if (!legionActivity.ContainsKey(legionName))
            {
                legionActivity.Add(legionName, activity);
                legionTypeCount.Add(legionName, new Dictionary<string, long>());
            }
            if (activity>legionActivity[legionName])
            {
                legionActivity[legionName] = activity;
            }
            if (!legionTypeCount[legionName].ContainsKey(soldierType))
            {
                legionTypeCount[legionName].Add(soldierType, 0);
            }
            legionTypeCount[legionName][soldierType] += count;
        }

        var commands = Console.ReadLine().Split('\\');

        if (commands.Length>1)
        {
            var activity = int.Parse(commands[0]);
            string type = commands[1];

            foreach (var item in legionTypeCount.Where(x => x.Value.ContainsKey(type))
                .OrderByDescending(x => x.Value[type]))
            {
                if (legionActivity[item.Key]<activity)
                {
                    Console.WriteLine($"{item.Key} -> {legionTypeCount[item.Key][type]}");
                }
            }
        }
        else
        {
            string type = commands[0];

            foreach (var item in legionActivity.OrderByDescending(x=>x.Value))
            {
                if (legionTypeCount[item.Key].ContainsKey(type))
                {
                    Console.WriteLine($"{item.Value} : {item.Key}");
                }

            }
        }
    }
}
