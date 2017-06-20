using System;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Delete":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (int.Parse(command[1])==input[i])
                            {
                                input.Remove(input[i]);
                                i--;
                            }
                        }
                        break;
                    case "Insert":
                        input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Odd":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i]%2==0)
                            {
                                input.Remove(input[i]);
                                i--;
                            }
                        }
                        Console.WriteLine(string.Join(" ",input));
                        return;
                    case "Even":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 1)
                            {
                                input.Remove(input[i]);
                                i--;
                            }
                        }
                        Console.WriteLine(string.Join(" ", input));
                        return;
                }
            }
        }
    }
}
