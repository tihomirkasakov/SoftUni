using System;
using System.Linq;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimer ={' ', '.', ',', ':', ';', '(', ')', '[', ']'
                , '\"', '\'', '\'', '\\', '/', '!', '?' };

            var input=Console.ReadLine().ToLower()
                .Split(delimer , StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();

            Console.WriteLine(string.Join(", ",input));
        }
    }
}
