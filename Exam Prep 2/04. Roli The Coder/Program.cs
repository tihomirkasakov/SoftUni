using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(?<id>\d+)\s+#(?<event>\w+)\s*(?<participants>(?:@[a-zA-Z0-9'-]+\s*)*)";
            var info = new Dictionary<int, Event>();

            while (input != "Time for Code")
            {
                var validInput = Regex.Match(input, pattern);
                if (validInput.Success)
                {
                    var id = int.Parse(validInput.Groups["id"].Value);
                    var events = validInput.Groups["event"].Value;
                    var participants = validInput.Groups["participants"].Value;
                    var zeroParticipants = new string[0];
                    if (participants.Length>0)
                    {
                        zeroParticipants = participants.Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
                    }
                    if (!info.ContainsKey(id))
                    {
                        info[id] = new Event()
                        {
                            Name = events,
                            Participants = new List<string>()
                        };
                    }
                    if (info[id].Name==events)
                    {
                        info[id].Participants.AddRange(zeroParticipants);
                        info[id].Participants=info[id].Participants.Distinct().ToList();
                    }
                    input = Console.ReadLine();
                }
            }
            var sortedEvent = info.OrderByDescending(x => x.Value.Participants.Count)
                .ThenByDescending(x => x.Value.Name).ToArray();
           
            foreach (var item in sortedEvent)
            {
                var eventA = item.Value.Name;
                var participantsCount = item.Value.Participants.Count;
                Console.WriteLine($"{eventA} - {participantsCount}");
           
                var sortedParticipants = item.Value.Participants.OrderBy(x => x);
                foreach (var itemz in sortedParticipants)
                {
                    Console.WriteLine(itemz);
                }
            }

        }
    }
    class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
}