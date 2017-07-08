using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }

                var number = int.Parse(Console.ReadLine());
                var pattern = $@"^(?<firstdigit>\d+)(?<chars>[a-zA-Z]{{{number}}})(?<seconddigit>[^a-zA-Z]*)$";
                var matches = Regex.Match(input, pattern);
                if (matches.Success)
                {
                    var firstdigits = matches.Groups["firstdigit"].Value;
                    var message = matches.Groups["chars"].Value;
                    var lastdigits = matches.Groups["seconddigit"].Value;
                    var indexes = string.Concat(firstdigits, lastdigits).Where(char.IsDigit).Select(x=>x-'0');
                    var result = new StringBuilder();

                    foreach (var item in indexes)
                    {
                        if (item<0||item>=message.Length)
                        {
                            result.Append(' ');
                        }
                        else
                        {
                            result.Append(message[item]);
                        }
                    }
                    Console.WriteLine($"{message} == {result}");
                }
            }
        }
    }
}
