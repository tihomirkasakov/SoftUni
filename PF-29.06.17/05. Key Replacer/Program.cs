using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine().Split(new[] { '|', '<', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();
            var firstKey = key[0];
            var lastKey = key[key.Length - 1];
            var pattern = $@"(?<={firstKey}).*?(?={lastKey})";
            var message = string.Empty;
            var validWord = Regex.Matches(text, pattern);
            foreach (Match item in validWord)
            {
                message += item;
            }
            if (message==string.Empty)
            {
                Console.WriteLine("Empty result");
                return;
            }
            Console.WriteLine(message);
        }
    }
}
