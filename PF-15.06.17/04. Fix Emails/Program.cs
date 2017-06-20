using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string email = string.Empty;
            Dictionary<string, string> output = new Dictionary<string, string>();
            int evenOdd = 1;
            while (name!="stop")
            {
                email = Console.ReadLine();
                if (evenOdd%2==1)
                {
                    if (!output.ContainsKey(name))
                    {
                        output[name] = string.Empty;
                    }
                    evenOdd++;
                }
                if(evenOdd%2==0)
                {
                    output[name] = email;
                    evenOdd++;
                }
                name = Console.ReadLine();
            }
            foreach (var item in output)
            {
                if (!item.Value.Contains(".uk")&&!item.Value.Contains(".us"))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
