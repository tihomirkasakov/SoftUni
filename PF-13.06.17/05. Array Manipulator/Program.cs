using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var commands = Console.ReadLine().Split().ToList();

                switch (commands[0])
                {
                    case "print":
                        Console.WriteLine("["+string.Join(", ",input)+"]");
                        return;

                    case "add":
                        int index = int.Parse(commands[1]);
                        int item = int.Parse(commands[2]);
                        if (index>=0&&index<input.Count)
                        {
                            input.Insert(index, item);
                        }
                        else if(index>=0&&index>=input.Count)
                        {
                            input.Add(item);
                        }
                        break;

                    case "addMany":
                        List<int> addMany = new List<int>();
                        for (int i = 2; i < commands.Count; i++)
                        {
                            addMany.Add(int.Parse(commands[i]));
                        }
                        for (int i = addMany.Count - 1; i >= 0; i--)
                        {
                            input.Insert(int.Parse(commands[1]), addMany[i]);
                        }
                        break;
                    case "contains":
                        int element = int.Parse(commands[1]);
                        Console.WriteLine(input.IndexOf(element));
                        break;
                    case "remove":
                        if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < input.Count)
                        {
                            input.RemoveAt(int.Parse(commands[1]));
                        }
                        break;
                    case "shift":
                        for (int i = 0; i < int.Parse(commands[1]); i++)
                        {
                            var temp = input[0];
                            input.RemoveAt(0);
                            input.Add(temp);
                        }
                        break;
                    case "sumPairs":
                        List<int> sumOfPairs = new List<int>();
                        for (int i = 0; i < input.Count; i += 2)
                        {
                            if (i + 1 < input.Count)
                                sumOfPairs.Add(input[i] + input[i + 1]);
                            else
                                sumOfPairs.Add(input[i]);
                        }
                        input = sumOfPairs;
                        break;
                }
            }
        }
    }
}
