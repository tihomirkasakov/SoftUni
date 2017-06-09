using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            switch (parameter)
            {
                case "face":
                    double faceOfCube = FaceOfCube(sideOfCube);
                    Console.WriteLine($"{faceOfCube:f2}");
                    break;
                case "space":
                    double spaceOfCube = SpaceOfCube(sideOfCube);
                    Console.WriteLine($"{spaceOfCube:f2}");
                    break;
                case "volume":
                    double volumeOfCube = VolumeOfCube(sideOfCube);
                    Console.WriteLine($"{volumeOfCube:f2}");
                    break;
                case "area":
                    double areaOfCube = AreaOfCube(sideOfCube);
                    Console.WriteLine($"{areaOfCube:f2}");
                    break;
            }
        }

        static double FaceOfCube(double sideOfCube)
        {
            double faceOfCube = Math.Sqrt(2 * sideOfCube * sideOfCube);
            return faceOfCube;
        }

        static double SpaceOfCube(double sideOfCube)
        {
            double spaceOfCube = Math.Sqrt(3 * sideOfCube * sideOfCube);
            return spaceOfCube;
        }

        static double VolumeOfCube(double sideOfCube)
        {
            double volumeOfCube = sideOfCube*sideOfCube*sideOfCube;
            return volumeOfCube;
        }

        static double AreaOfCube(double sideOfCube)
        {
            double areaOfCube = 6*sideOfCube*sideOfCube;
            return areaOfCube;
        }

    }
}
