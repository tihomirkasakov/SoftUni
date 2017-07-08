using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var pattern = @"\b[a-zA-Z]\w{2,24}\b";
            var validUsernames = new List<string>();
            var longestUsernamesPair = new List<string>();
            var sum = 0;
            for (int i = 0; i < usernames.Length; i++)
            {
                if (Regex.IsMatch(usernames[i],pattern))
                {
                    validUsernames.Add(usernames[i]);
                }
            }
            for (int i = 1; i < validUsernames.Count; i++)
            {
                var firstUsername = validUsernames[i - 1];
                var secondUsername = validUsernames[i];
                var currentSum = firstUsername.Length + secondUsername.Length;
                if (currentSum>sum)
                {
                    sum = currentSum;
                    longestUsernamesPair.Clear();
                    longestUsernamesPair.Add(firstUsername);
                    longestUsernamesPair.Add(secondUsername);
                }
            }
            Console.WriteLine(string.Join("\n",longestUsernamesPair));
        }
    }
}
