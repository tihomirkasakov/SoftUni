using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Price_Change_Alert
{
    class Program
    {
       static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double granica = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double c = double.Parse(Console.ReadLine());
            double div = Proc(last, c);
            bool isSignificantDifference = imaliDif(div, granica);
            string message = Get(c, last, div, isSignificantDifference);
            Console.WriteLine(message);
            last = c;
        }
    }
    static string Get(double c, double last, double div, bool isSignificantDifference)
    {
        string to = "";
        if (div == 0)
        {
            to = string.Format($"NO CHANGE: {c}");
                return to;
        }
        if (!isSignificantDifference)
        {
            to = string.Format($"MINOR CHANGE: {last} to {c} ({div:F2}%)");
                return to;
        }
        if (isSignificantDifference && (div > 0))
        {
            to = string.Format($"PRICE UP: {last} to {c} ({div:F2}%)");
                return to;
        }
        else if (isSignificantDifference && (div < 0))
        {
            to = string.Format($"PRICE DOWN: {last} to {c} ({div:F2}%)");
            return to;
        }
    }

    private static bool imaliDif(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double last, double c)
    {
        double r = (c - last) / last;
        return r;
    }
    }
}
