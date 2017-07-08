using System;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().TrimStart(new char[] {'0'}).ToCharArray();
            var input2 = Console.ReadLine().TrimStart(new char[] {'0'}).ToCharArray();
            string result = string.Empty;
            int sum = 0;
            for (int i = 0; i < Math.Min(input1.Length,input2.Length); i++)
            {
                int firstNumber = int.Parse(input1[input1.Length - 1 - i].ToString());
                int secondNumber=int.Parse(input2[input2.Length - 1 - i].ToString());
                sum =  firstNumber+ secondNumber+sum;
                if (sum>=10)
                {
                    result = sum%10 + result;
                    sum = sum / 10;
                }
                else
                {
                    result = sum + result;
                    sum = 0;
                }
            }
            for (int i = Math.Min(input1.Length,input2.Length); i < Math.Max(input1.Length,input2.Length); i++)
            {
                var longerNumber = input1.Length > input2.Length ? input1 : input2;
                sum = int.Parse(longerNumber[longerNumber.Length-1-i].ToString()) + sum;
                if (sum >= 10)
                {
                    result = sum % 10 + result;
                    sum = sum / 10;
                }
                else
                {
                    result = sum + result;
                    sum = 0;
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
