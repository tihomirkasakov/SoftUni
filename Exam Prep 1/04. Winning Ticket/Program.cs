using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ','},StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();
            var symbols = new string[] { "@", "#", "\\$", "\\^" };
            for (int word = 0; word < input.Length; word++)
            {
                if (input[word].Trim().Length!=20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var leftSide = new string (input[word].Take(10).ToArray());
                var rightSide = new string(input[word].Skip(10).ToArray());
                var winning = false;
                foreach (var item in symbols)
                {
                    var pattern = $@"{item}{{6,10}}";
                    var validLeftSide = Regex.Match(leftSide, pattern);
                    var validRightSide = Regex.Match(rightSide, pattern);
                    if (validLeftSide.Success)
                    {
                        if (validRightSide.Success)
                        {
                            winning = true;

                            if (validLeftSide.Length==10&&validRightSide.Length==10)
                            {
                                Console.WriteLine($"ticket \"{input[word]}\" - {validLeftSide.Value.Length}{item.Trim('\\')} Jackpot!");
                            }
                            else
                            {
                                if (validLeftSide.Value.Length<validRightSide.Value.Length)
                                {
                                    Console.WriteLine($"ticket \"{input[word]}\" - {validLeftSide.Value.Length}{item.Trim('\\')}");
                                }
                                else
                                {
                                    Console.WriteLine($"ticket \"{input[word]}\" - {validRightSide.Value.Length}{item.Trim('\\')}");
                                }
                            }
                            break;
                        }
                    }
                }
                if (winning==false)
                {
                    Console.WriteLine($"ticket \"{input[word]}\" - no match");
                }
            }
        }
    }
}
