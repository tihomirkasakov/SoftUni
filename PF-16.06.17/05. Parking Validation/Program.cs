using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfInputs = int.Parse(Console.ReadLine());
            var inOut = new Dictionary<string, string>();
            for (int i = 0; i < numberOfInputs; i++)
            {
                var input = Console.ReadLine().Split();
                var registerUn = input[0];
                var user = input[1];
                if (registerUn=="register")
                {
                    var carPlate = input[2];
                    if (!inOut.ContainsKey(user))
                    {
                        if (carPlate.Length == 8)
                        {
                            var k = carPlate.Length / 4;
                            bool firstTwo = carPlate.ToCharArray().Take(2).All(x => char.IsUpper(x));
                            bool lastTwo = carPlate.ToCharArray().Skip(6).Take(2).All(x => char.IsUpper(x));
                            bool midPArt = carPlate.ToCharArray().Skip(2).Take(4).All(x => char.IsDigit(x));
                            if (!firstTwo || !midPArt || !lastTwo)
                            {
                                Console.WriteLine($"ERROR: invalid license plate {carPlate}");
                                continue;
                            }
                        }
                        if (!inOut.Values.Contains(carPlate))
                        {
                            inOut[user] = carPlate;
                            Console.WriteLine($"{user} registered {carPlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: license plate {carPlate} is busy");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {inOut[user]}");
                    }
                }
                else if (registerUn=="unregister")
                {
                    if (!inOut.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {user} unregistered successfully");
                        inOut.Remove(user);
                    }
                }
            }
            foreach (var item in inOut)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
