using System;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberInput = double.Parse(Console.ReadLine());

            if (numberInput >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
