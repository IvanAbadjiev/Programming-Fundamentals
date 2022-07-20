using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());

            decimal convertPoundToUsDolar = pound * (decimal)1.31;

            Console.WriteLine($"{convertPoundToUsDolar:f3}");
        }
    }
}
