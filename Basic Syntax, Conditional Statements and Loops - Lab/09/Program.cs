using System;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberLines = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 1; i <= numberLines * 2; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
