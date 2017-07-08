using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main()
        {
            var privateMessages = new List<string>();
            var broadcasts = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input== "Hornet is Green")
                {
                    break;
                }
                var privateMessagePattern = @"^(?<code>\d+)\s+<->\s+(?<message>[a-zA-Z0-9]+)$";
                var broadcastPattern = @"^(?<message>\D+)\s+<->\s+(?<frequency>[a-zA-Z0-9]+)$";
                var isValidPM = Regex.Match(input, privateMessagePattern);
                var isValidBC = Regex.Match(input, broadcastPattern);

                if (!isValidPM.Success&&!isValidBC.Success)
                {
                    continue;
                }

                if (isValidPM.Success)
                {
                    var code = new string(isValidPM.Groups["code"].Value.Reverse().ToArray());
                    var message = isValidPM.Groups["message"].Value;
                    privateMessages.Add($"{code} -> {message}");
                }

                if (isValidBC.Success)
                {
                    var frequency = isValidBC.Groups["frequency"].Value;
                    var message = isValidBC.Groups["message"].Value;

                    var editedFrequency = new StringBuilder();
                    foreach (var item in frequency)
                    {
                        if (item >= 65 && item <= 90)
                        {
                            editedFrequency.Append((char)(item+32));
                        }
                        else if (item>=97&&item<=122)
                        {
                            editedFrequency.Append((char)(item-32));
                        }
                        else
                        {
                            editedFrequency.Append(item);
                        }
                    }

                    broadcasts.Add($"{editedFrequency} -> {message}");
                }
            }
            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Count>0 ? string.Join("\n",broadcasts):"None");

            Console.WriteLine("Messages:");
            Console.WriteLine(privateMessages.Count>0 ? string.Join("\n",privateMessages):"None");
        }
    }
}
