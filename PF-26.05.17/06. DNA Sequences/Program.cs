using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            for (int first = 1; first <= 4; first++)
            {
                for (int second = 1; second <= 4; second++)
                {
                    for (int third = 1; third <= 4; third++)
                    {
                        count++;
                        if (first+second+third>=n)
                        {
                            Console.Write("O"+(""+first+second+third).Replace('1','A').Replace('2','C').Replace('3','G').Replace('4','T')+"O ");
                        }
                        else
                        {
                            Console.Write("X" + ("" + first + second + third).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }
                        if (count%4==0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
