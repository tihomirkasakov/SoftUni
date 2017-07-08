using System;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().TrimStart(new char[] { '0' }).ToCharArray();
            var input2 = Console.ReadLine().ToCharArray();
            string result = string.Empty;
            int sum = 0;
            for (int i = 0; i < input2.Length; i++)
            {
                var multiplyBy = int.Parse(input2[input2.Length - 1 - i].ToString());
                if (multiplyBy==0)
                {
                    result = "0";
                    break;
                }
                for (int j = 0; j < input1.Length; j++)
                {
                    var multiplyNumber = int.Parse(input1[input1.Length - 1 - j].ToString());
                    sum = multiplyNumber * multiplyBy+sum;
                    result = sum % 10 + result;
                    sum /= 10;
                }
            }
            if (sum>0)
            {
                result = sum + result;
            }
            Console.WriteLine(result);
        }
    }
}
