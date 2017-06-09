using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _1000days_after_birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime dayOfBirth = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime answer = dayOfBirth.AddDays(999);
            Console.WriteLine(answer.ToString("dd-MM-yyyy"));

        }
    }
}
