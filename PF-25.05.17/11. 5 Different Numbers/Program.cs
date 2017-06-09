using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (Math.Abs(a-b)<5)
            {
                Console.WriteLine("No");
            }
            for (int first = a; first <= b; first++)
            {
                for (int second = a; second <= b; second++)
                {
                    for (int third = a; third <= b; third++)
                    {
                        for (int forth = a; forth <=b; forth++)
                        {
                            for (int fifth = a; fifth <=b; fifth++)
                            {
                                if (first>=second||second>=third||third>=forth||forth>=fifth)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.Write(first+" ");
                                    Console.Write(second+" ");
                                    Console.Write(third+" ");
                                    Console.Write(forth+" ");
                                    Console.WriteLine(fifth);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
