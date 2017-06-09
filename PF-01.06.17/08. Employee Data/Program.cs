using System;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char sex = 'f';
            double ID = 8306112507;
            int number = 27563571;
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {sex}");
            Console.WriteLine($"Personal ID: {ID}");
            Console.WriteLine($"Unique Employee number: {number}");
        }
    }
}
