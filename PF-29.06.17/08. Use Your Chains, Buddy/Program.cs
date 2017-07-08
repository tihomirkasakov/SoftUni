using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(?<=<p>).*?(?=<\/p>)";
            var selectedText = Regex.Matches(input, pattern);
            var text = string.Empty;
            foreach (Match item in selectedText)
            {
                text += item.Value;
            }
            var pattern2 = @"[\W_A-Z]+";
            var onlyValidSymbols = Regex.Replace(text, pattern2, " ");
            StringBuilder decodedText = new StringBuilder();
            foreach (char item in onlyValidSymbols)
            {
                if (item>='a'&&item<='m')
                {
                    decodedText.Append((char)(item + 13));
                }
                else if (item>='n'&&item<='z')
                {
                    decodedText.Append((char)(item - 13));
                }
                else
                {
                    decodedText.Append(item);
                }
            }
            Console.WriteLine(decodedText);
        }
    }
}
