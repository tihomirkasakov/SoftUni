using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var size = decimal.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var counter = 0;

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            while (size>1000)
            {
                counter++;
                size = Math.Round(size/1000,1);
            }
            switch (counter)
            {
                case 0: Console.WriteLine($"Size: {size}B");
                    break;
                case 1: Console.WriteLine($"Size: {size}KB");
                    break;
                case 2: Console.WriteLine($"Size: {size}MB");
                    break;
                case 3: Console.WriteLine($"Size: {size}GB");
                    break;
                default:
                    Console.WriteLine("Kva e tazi snimka");
                    break;
            }
            if (width>height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (width==height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
            else if (width<height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
        }
    }
}
