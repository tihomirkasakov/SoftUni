using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05___SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = (12 * a - 6) / 2;

            for (int row = 0; row < 2*a; row++)
            {
               for (int p = b ; p > 0; p--)
               {
                   Console.Write(".");
               }
               for (int d = 1; d <= 1+(6*row); d++)
               {
                   Console.Write("#");
               }
               for (int p = b; p > 0; p--)
               {
                   Console.Write(".");
               }
               Console.WriteLine();
               b -= 3;
            }

            for (int i = 0; i < a-2; i++)
            {
                Console.WriteLine("|"+new string('.',(i*3)+2)+new string('#',((12*a-5)-6*(i+1)))+new string('.', (i * 3)+3));
            }
            
            for (int bot = 0; bot < a-1; bot++)
            {
                Console.WriteLine("|"+ new string('.', 3*a-4) + new string('#',6*a+1)+new string('.',3*(a-1)));
            }
            Console.WriteLine("@" + new string('.', 3 * a - 4) + new string('#', 6 * a + 1) + new string('.', 3 * (a - 1)));
        }
    }
}
