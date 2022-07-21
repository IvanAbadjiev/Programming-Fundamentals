using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var symbol = Console.ReadLine();

            Console.WriteLine($"{firstName}{symbol}{lastName}");
        }
    }
}
