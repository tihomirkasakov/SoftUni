using System;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|\s)[a-z]+(\.\w+|-\w+)?@\w+(-\w+)?\.\w+(\.\w+)?";
            var input = Console.ReadLine();
            var validEmails = Regex.Matches(input, regex);
            foreach (Match email in validEmails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
