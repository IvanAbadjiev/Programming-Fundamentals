using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var metar = int.Parse(Console.ReadLine());

            var convertMetarToKilometar = metar * 0.001; ;

            Console.WriteLine($"{convertMetarToKilometar:f2}");
        }
    }
}
