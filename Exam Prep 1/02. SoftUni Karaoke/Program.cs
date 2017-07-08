using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(new[] {", "},StringSplitOptions.RemoveEmptyEntries);
            var songs = Console.ReadLine().Split(new[] { ", "}, StringSplitOptions.RemoveEmptyEntries);
            var participatsAwards = new Dictionary<string, HashSet<string>>();
            var psa = Console.ReadLine().Split(new[] { ", "}, StringSplitOptions.RemoveEmptyEntries);

            while (psa[0]!="dawn")
            {
                var participant = psa[0].Trim();
                var song = psa[1].Trim();
                var award = psa[2].Trim();
                for (int singer = 0; singer < participants.Length; singer++)
                {
                    for (int track = 0; track < songs.Length; track++)
                    {
                        if (participant == participants[singer] && song==songs[track] && !participatsAwards.ContainsKey(participant))
                        {
                            participatsAwards[participant] = new HashSet<string>();
                            participatsAwards[participant].Add(award);
                        }
                        else if (participant == participants[singer] && song == songs[track] && participatsAwards.ContainsKey(participant))
                        {
                            participatsAwards[participant].Add(award);
                        }
                    }
                }
                psa = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            }
            if (participatsAwards.Keys.Count==0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var item in participatsAwards.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                var name = item.Key;
                var awards = item.Value.OrderBy(x=>x);
                    Console.WriteLine($"{name}: {item.Value.Count} awards");
                    Console.WriteLine("--" + string.Join("\n--", awards));
            }
        }
    }
}
