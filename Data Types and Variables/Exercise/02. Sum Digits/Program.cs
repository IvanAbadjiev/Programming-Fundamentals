using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            while (inputNumber != 0)
            {
                int lastDigit = inputNumber % 10;
                sum += lastDigit;
                inputNumber /= 10;


            }

            Console.WriteLine(sum);


        }
    }
}
