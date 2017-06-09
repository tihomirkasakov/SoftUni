using System;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            byte numberOfMoves = byte.Parse(Console.ReadLine());
            byte firstBoatMoves = 0;
            byte secondBoatMoves = 0;

                for (int i = 1; i <= numberOfMoves; i++)
                {
                    string word = Console.ReadLine();
                    if (word == "UPGRADE")
                    {
                        firstBoat += (char)3;
                        secondBoat += (char)3;
                    }
                    else
                    {
                        if (i % 2 == 1)
                        {
                            firstBoatMoves += (byte)word.Length;
                        }
                        else
                        {
                            secondBoatMoves += (byte)word.Length;
                        }
                        if (firstBoatMoves >= 50 || secondBoatMoves >= 50)
                        {
                            break;
                        }
                    }
                }
            Console.WriteLine(firstBoatMoves>secondBoatMoves?firstBoat:secondBoat);
        }
    }
}
