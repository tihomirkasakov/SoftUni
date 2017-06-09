using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            #region top
            Console.Write(new string('-',3*a));
            Console.Write(new string('*',2));
            Console.WriteLine(new string('-',2*a-2));
            #endregion

            #region 1
            for (int i = 1; i <= a-1; i++)
            {
                Console.Write(new string('-', 3 * a));
                Console.Write("*"+new string('-',i)+"*"+new string('-',2*a-(2+i)));
                Console.WriteLine();
            }

            #endregion

            #region mid
            for (int i = 1; i <=a/2; i++)
            {
                Console.Write(new string('*', 3 * a));
                for (int dryjka = 1; dryjka <= 2; dryjka++)
                {
                    Console.Write("*");
                    Console.Write(new string('-', a - 1));
                }
                Console.WriteLine();
            }
            #endregion

            #region 2
            var b = a / 2 - 1;
            for (int i = 1; i <=b; i++)
            {
                var dash1 = 3 * a - (i - 1);
                var dash2= (a - 1) + (i - 1) * 2;
                Console.Write(new string('-',dash1)+"*");
                Console.Write(new string('-',dash2)+"*");
                Console.WriteLine(new string('-',5*a-dash1-dash2-2));
            }

            #endregion

            #region bot

            var stars = (a * 2 - 1) - a % 2;
            var dash = ((a * 3) - ((a / 2)-1));
            Console.Write(new string('-',dash)+new string('*',stars)+new string('-',5*a-(dash+stars)));
            #endregion

        }
    }
}
