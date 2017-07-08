using System;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main()
        {
            int orders = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < orders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture);
                decimal daysInMonth = DateTime.DaysInMonth(date.Year,date.Month);
                decimal capsules = decimal.Parse(Console.ReadLine());

                decimal orderPrice = (daysInMonth * capsules) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                total += orderPrice;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
