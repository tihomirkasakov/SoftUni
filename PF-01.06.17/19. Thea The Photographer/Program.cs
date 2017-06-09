using System;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var picturesTaken = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var goodPictures = int.Parse(Console.ReadLine());
            var filtredTime = int.Parse(Console.ReadLine());
            
            var timeForCheck = (long)picturesTaken * filterTime;
            var usefullPictures = (long)Math.Ceiling(picturesTaken * (goodPictures / 100d));
            var uploadTime = usefullPictures * filtredTime;
            var totalTime = timeForCheck + uploadTime;

            byte seconds = (byte)(totalTime % 60);
            totalTime = (totalTime - (totalTime % 60)) / 60;
            byte minutes = (byte)(totalTime % 60);
            totalTime = (totalTime - (totalTime % 60)) / 60;
            byte hours = (byte)(totalTime % 24);
            totalTime = (totalTime - (totalTime % 24)) / 24;
            Console.WriteLine($"{totalTime}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
