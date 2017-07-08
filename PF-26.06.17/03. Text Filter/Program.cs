using System;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();
            foreach (var item in separators)
            {
                if (input.Contains(item))
                {
                    input = input.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(input);
        }
    }
}
