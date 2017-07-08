using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var key = Console.ReadLine();
        key = Regex.Escape(key);
        var teamPattern = $@"{key}(.*?){key}.+?{key}(.*?){key}.+?(\d+):(\d+)";

        var teamsPoints = new Dictionary<string, long>();
        var teamsGoals = new Dictionary<string, long>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input=="final")
            {
                break;
            }
            var match = Regex.Match(input, teamPattern);
            var homeTeam = new string(match.Groups[1].Value.Reverse().ToArray()).ToUpper();
            var awayTeam = new string(match.Groups[2].Value.Reverse().ToArray()).ToUpper();
            var homeGoals = int.Parse(match.Groups[3].Value);
            var awayGoals = int.Parse(match.Groups[4].Value);

            if (!teamsPoints.ContainsKey(homeTeam))
            {
                teamsPoints[homeTeam] = 0;
            }
            if (!teamsPoints.ContainsKey(awayTeam))
            {
                teamsPoints[awayTeam] = 0;
            }
            if (!teamsGoals.ContainsKey(homeTeam))
            {
                teamsGoals[homeTeam] = 0;
            }
            if (!teamsGoals.ContainsKey(awayTeam))
            {
                teamsGoals[awayTeam] = 0;
            }
            teamsGoals[homeTeam] += homeGoals;
            teamsGoals[awayTeam] += awayGoals;

            if (homeGoals>awayGoals)
            {
                teamsPoints[homeTeam] += 3;
            }
            else if (awayGoals>homeGoals)
            {
                teamsPoints[awayTeam] += 3;
            }
            else
            {
                teamsPoints[homeTeam] += 1;
                teamsPoints[awayTeam] += 1;
            }
        }

        var sortedByPoints = teamsPoints.OrderByDescending(x => x.Value).ThenBy(x=>x.Key);
        Console.WriteLine("League standings:");
        var place = 0;
        foreach (var item in sortedByPoints)
        {
            place++;
            Console.WriteLine($"{place}. {item.Key} {item.Value}");
        }
        var sortedByGoals = teamsGoals.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).Take(3);
        Console.WriteLine("Top 3 scored goals:");
        foreach (var item in sortedByGoals)
        {
            Console.WriteLine($"- {item.Key} -> {item.Value}");
        }
    }
}