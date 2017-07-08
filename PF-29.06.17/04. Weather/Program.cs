using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"([A-Z]{2})(\d+.\d+)([a-zA-Z]+)\|";
            var info = new Dictionary<string, TempWeather>();

            while (input!="end")
            {
                var validInput = Regex.Match(input, pattern);
                if (!validInput.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var city = validInput.Groups[1].Value;
                var temp = double.Parse(validInput.Groups[2].Value);
                var weather = validInput.Groups[3].Value;

                var weatherInfo = new TempWeather
                {
                    Temperature = temp,
                    Weather = weather
                };

                info[city] = weatherInfo;
                input = Console.ReadLine();
            }
            var sortedTemp = info.OrderBy(x => x.Value.Temperature).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedTemp)
            {
                var cities = item.Key;
                var temperature = item.Value.Temperature;
                var weather = item.Value.Weather;
                Console.WriteLine($"{cities} => {temperature:f2} => {weather}");
            }
        }
    }
    class TempWeather
    {
        public double Temperature { get; set; }
        public string Weather { get; set; }
    }
}
