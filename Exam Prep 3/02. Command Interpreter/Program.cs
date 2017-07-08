using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" \t\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands = Console.ReadLine();
            while (commands != "end")
            {
                string[] snipp = commands.Split();
                var command = snipp[0];
                var startIndex = 0;
                long times = 0;
                var count = 0;


                switch (command)
                {
                    case "reverse":
                        startIndex = int.Parse(snipp[2]);
                        count = int.Parse(snipp[4]);
                        if (startIndex < 0 || startIndex >= elements.Count || (startIndex + count > elements.Count) || (count < 0))
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        elements = ReverseOrder(elements, startIndex, count);
                        break;
                    case "sort":
                        startIndex = int.Parse(snipp[2]);
                        count = int.Parse(snipp[4]);
                        if (startIndex < 0 || startIndex >= elements.Count || startIndex + count > elements.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        elements = SortOrder(elements, startIndex, count);
                        break;
                    case "rollLeft":
                        times = int.Parse(snipp[1]);
                        if (times<0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        elements = ShiftLeft(elements, times);
                        break;
                    case "rollRight":
                        times = int.Parse(snipp[1]);
                        if (times < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }
                        elements = ShiftRight(elements, times);
                        break;
                }

                commands = Console.ReadLine();

            }
            Console.Write("[");
            Console.Write(string.Join(", ", elements));
            Console.WriteLine("]");

        }

        private static List<string> ShiftRight(List<string> elements, long n)
        {
            for (int p = 0; p < n % elements.Count; p++)
            {
                var temp = elements[elements.Count - 1];
                for (int i = elements.Count - 1; i > 0; i--)
                {
                    elements[i] = elements[i - 1];
                }
                elements[0] = temp;
            }
            return elements;
        }

        private static List<string> ShiftLeft(List<string> elements, long n)
        {
            for (int p = 0; p < n % elements.Count; p++)
            {
                var temp = elements[0];
                for (int i = 0; i < elements.Count - 1; i++)
                {
                    elements[i] = elements[i + 1];
                }
                elements[elements.Count - 1] = temp;
            }
            return elements;
        }

        private static List<string> SortOrder(List<string> elements, int start, int length)
        {
            List<string> tempArray = new List<string>();
            for (int i = start; i < start + length; i++)
            {
                tempArray.Add(elements[i]);
            }
            tempArray.Sort();
            for (int i = start; i < start + length; i++)
            {
                elements[i] = tempArray[i - start];


            }
            return elements;
        }

        private static List<string> ReverseOrder(List<string> elements, int start, int length)
        {

            string[] tempArray = new string[length];
            for (int i = start; i < start + length; i++)
            {
                tempArray[i - start] = elements[i];
            }
            tempArray = tempArray.Reverse().ToArray();
            for (int i = start; i < start + length; i++)
            {
                elements[i] = tempArray[i - start];


            }

            return elements;
        }
    }
}
