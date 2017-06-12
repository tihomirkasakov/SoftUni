using System;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var array = new bool[number+1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }
            array[0] = false;
            array[1] = false;
            for (int i = 0; i <= number; i++)
            {
                if (!array[i])
                {
                    continue;
                }
                Console.Write(i + " ");
                for (int j = 2*i; j <= number; j+=i)
                {
                    array[j] = false;
                }
            }
        }
    }
}
