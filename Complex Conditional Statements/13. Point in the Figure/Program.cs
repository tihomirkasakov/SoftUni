using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var firstRectangle = (x > 0 && x < 3 * h && y > 0 && y < h);
            var secondRectangle = (x > h && x < 2 * h && y >= h && y < 4 * h);

            var bottom = (x >= 0 && x<=3*h && y==0);
            var bottomLeft = (x == 0 && y >= 0 && y <= h);
            var leftBottomTop = (x >= 0 && y == h && x<=h);
            var leftTopSide = (x == h && y >= h && y <= 4 * h);
            var top = (x >= h && x <= 2 * h && y == 4 * h);
            var rightSideTop = (x == 2 * h && y <= 4 * h && y >= h);
            var rightBottomTop = (x >= 2 * h && x <= 3 * h && y == h);
            var bottomRight = (y <= h && y >= 0 && x == 3 * h);

            if(firstRectangle||secondRectangle)
            {
                Console.WriteLine("inside");
            }
            else if(bottom||bottomLeft||leftBottomTop||leftTopSide||top||rightSideTop||rightBottomTop||bottomRight)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
