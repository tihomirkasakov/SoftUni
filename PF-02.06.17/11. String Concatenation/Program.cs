using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            byte numberOfLines = byte.Parse(Console.ReadLine());
            string concatenation = "";
          
            for (int i = 1; i <= numberOfLines; i++)
            {
                string word = Console.ReadLine();
                switch (oddOrEven)
                {
                    case "even":
                        if (i % 2 == 0)
                        {
                            concatenation += word + delimeter;
                        }
                        break;
                    case "odd":
                        if (i % 2 == 1)
                        {
                            concatenation += word + delimeter;
                        }
                        break;
                }
            }
            Console.WriteLine(concatenation.Remove(concatenation.Length-1));
        }
    }
}
