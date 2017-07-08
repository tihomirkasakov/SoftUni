using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Regex regex =new Regex("\\b"+keyword+"\\b");

            foreach (var item in text)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item.Trim());
                }
            }
        }
    }
}
