using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = elements[0];
            int lenght = elements[1];
            var cameras = Console.ReadLine();
            var pattern = @"(?<=\|<)(\W+)?[\w]+";
            var validCameras = Regex.Matches(cameras, pattern);
            var places = new List<string>();
            foreach (Match item in validCameras)
            {
                if (startIndex>item.Length)
                {
                    continue;
                }
                if (item.Length>=startIndex+lenght)
                {
                    places.Add(item.Value.Substring(startIndex, lenght));
                }
                else
                {
                    places.Add(item.Value.Substring(startIndex));
                }
            }
            Console.WriteLine(string.Join(", ",places));
        }
    }
}
