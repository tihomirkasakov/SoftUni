using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object concatenate = firstWord + " " + secondWord;
            string greating = (string)concatenate;
            Console.WriteLine(greating);
        }
    }
}
