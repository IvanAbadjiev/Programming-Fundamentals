using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());


            long result1 = (long)number1 + number2;
            long result2 = result1 / number3;
            long result3 = result2 * number4;

            Console.WriteLine(result3);
        }
    }
}
