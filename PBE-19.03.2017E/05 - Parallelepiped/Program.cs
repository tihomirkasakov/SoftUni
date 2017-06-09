using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            #region first row
            Console.WriteLine("+"+new string('~',n-2)+"+"+new string('.',2*n+1));
            #endregion

            #region mid top
            for (int i = 1; i <=2*n+1; i++)
            {
                Console.Write("|"+new string('.', i - 1));
                Console.Write("\\" + new string('~', n - 2) + "\\");
                Console.WriteLine(new string('.',2*n-(i-1)));
            }
            #endregion

            for (int i = 1; i <=2*n+1; i++)
            {
                Console.Write(new string('.',i-1)+"\\");
                Console.Write(new string('.',2*n-(i-1)));
                Console.WriteLine("|"+new string('~',n-2)+"|");
            }

            #region last row
            Console.WriteLine(new string('.', 2 * n + 1)+ "+" + new string('~', n - 2) + "+");
            #endregion
        }
    }
}
