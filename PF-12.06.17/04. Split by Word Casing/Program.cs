using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimer = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' '};
            var text = Console.ReadLine().Split(delimer).ToList();
            List<string> toLower = new List<string>();
            List<string> toUpper = new List<string>();
            List<string> mixed = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (text[i]=="")
                {
                    text.RemoveAt(i);
                }
            }

            for (int i = 0; i < text.Count; i++)
            {

                var upper = false;
                var lower = false;
                foreach (char item in text[i])
                {
                    if (char.IsLower(item))
                    {
                        lower=true;
                    }
                    else if (char.IsUpper(item))
                    {
                        upper=true;
                    }
                    else
                    {
                        lower = true;
                        upper = true;
                    }
                }

                if (lower && !upper)
                {
                    toLower.Add(text[i]);
                }
                else if (upper&&!lower)
                {
                    toUpper.Add(text[i]);
                }
                else if(upper&&lower)
                {
                    mixed.Add(text[i]);
                }
            }

            Console.WriteLine("Lower-case: "+string.Join(", ",toLower));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + string.Join(", ", toUpper));

        }
    }
}
