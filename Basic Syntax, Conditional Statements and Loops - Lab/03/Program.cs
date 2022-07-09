using System;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberInput = double.Parse(Console.ReadLine());

            if (numberInput >= 3)
            {
                Console.WriteLine("Passed!");
            } else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
