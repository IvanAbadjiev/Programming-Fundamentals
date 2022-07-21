using System;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var townName = Console.ReadLine();
            var population = Console.ReadLine();
            var area = Console.ReadLine();

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
