using System;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var delimer = Console.ReadLine();
            while (true)
            {
                int first = input.IndexOf(delimer);
                int last = input.LastIndexOf(delimer);
                if (first > -1 && last > -1 && first != last&&delimer.Length>0)
                {
                    input = input.Remove(first, delimer.Length);
                    last = input.LastIndexOf(delimer);
                    input = input.Remove(last, delimer.Length);
                    Console.WriteLine("Shaked it.");
                        delimer = delimer.Remove(delimer.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
