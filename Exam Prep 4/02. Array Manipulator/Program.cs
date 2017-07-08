using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var inputArray = Console.ReadLine().Split().Select(int.Parse).ToList();
        var commands = Console.ReadLine().ToLower();
        while (commands != "end")
        {
            var commandsArray = commands.Split();
            var command = commandsArray.First();
            if (command == "exchange")
            {
                var exchangeIndex = int.Parse(commandsArray[1]);
                if (exchangeIndex < 0 || exchangeIndex > inputArray.Count - 1)
                {
                    Console.WriteLine("Invalid index");
                    commands = Console.ReadLine();
                    continue;
                }
                int length = inputArray.Count;
                var tempArray = inputArray.Skip(exchangeIndex + 1).ToList();
                inputArray.InsertRange(0, tempArray);
                inputArray.RemoveRange(length, tempArray.Count);
            }

            var oddNumbers = new List<int>();
            var evenNumbers = new List<int>();
            foreach (var item in inputArray)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Add(item);
                }
                else
                {
                    oddNumbers.Add(item);
                }
            }

            if (command=="max")
            {
                if (commandsArray[1]=="odd")
                {
                    if (oddNumbers.Count==0)
                    {
                        Console.WriteLine("No matches");
                        commands = Console.ReadLine().ToLower();
                        continue;
                    }
                    Console.WriteLine(inputArray.LastIndexOf(oddNumbers.Max()));
                }
                else if (commandsArray[1] == "even")
                {
                    if (evenNumbers.Count==0)
                    {
                        Console.WriteLine("No matches");
                        commands = Console.ReadLine().ToLower();
                        continue;
                    }
                    Console.WriteLine(inputArray.LastIndexOf(evenNumbers.Max()));
                }
            }
            if (command=="min")
            {
                if (commandsArray[1] == "odd")
                {
                    if (oddNumbers.Count == 0)
                    {
                        Console.WriteLine("No matches");
                        commands = Console.ReadLine().ToLower();
                        continue;
                    }
                    Console.WriteLine(inputArray.LastIndexOf(oddNumbers.Min()));
                }
                else if (commandsArray[1] == "even")
                {
                    if (evenNumbers.Count == 0)
                    {
                        Console.WriteLine("No matches");
                        commands = Console.ReadLine().ToLower();
                        continue;
                    }
                    Console.WriteLine(inputArray.LastIndexOf(evenNumbers.Min()));
                }
            }
            if (command=="first")
            {
                var firstCount = int.Parse(commandsArray[1]);
                if (firstCount>inputArray.Count||firstCount<0)
                {
                    Console.WriteLine("Invalid count");
                    commands = Console.ReadLine().ToLower();
                    continue;
                }
                var evenOrOdd = commandsArray[2];
                if (evenOrOdd=="even")
                {
                    Console.WriteLine("["+string.Join(", ",evenNumbers.Take(firstCount))+"]");

                }
                if (evenOrOdd=="odd")
                {
                    Console.WriteLine("[" + string.Join(", ", oddNumbers.Take(firstCount)) + "]");
                }
            }
            if (command=="last")
            {
                var firstCount = int.Parse(commandsArray[1]);
                if (firstCount > inputArray.Count || firstCount < 0)
                {
                    Console.WriteLine("Invalid count");
                    commands = Console.ReadLine().ToLower();
                    continue;
                }
                var evenOrOdd = commandsArray[2];
                if (evenOrOdd == "even")
                {
                    Console.WriteLine("[" + string.Join(", ", evenNumbers.Skip(evenNumbers.Count-firstCount).Take(firstCount)) + "]");

                }
                if (evenOrOdd == "odd")
                {
                    Console.WriteLine("[" + string.Join(", ", oddNumbers.Skip(oddNumbers.Count-firstCount).Take(firstCount)) + "]");
                }
            }

            commands = Console.ReadLine().ToLower();
        }
        Console.WriteLine("["+string.Join(", ",inputArray)+"]");
    }
}

