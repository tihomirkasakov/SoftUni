using System;
using System.Linq;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Where(x=>x.Length==2).Reverse().ToList();
            for (int i = 0; i < input.Count; i++)
            {
                string reverse = new string (input[i].ToCharArray().Reverse().ToArray());
                input[i] = reverse;
            }
            string word = string.Empty;
            foreach (var item in input)
            {
                var convert = Convert.ToInt32(item, 16);
                word += (char)convert;
            }
            Console.WriteLine(word);
        }
    }
}
